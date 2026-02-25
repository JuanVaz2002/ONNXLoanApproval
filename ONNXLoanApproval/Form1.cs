using System;
using System.Threading.Tasks;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;

namespace ONNXLoanApproval
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ConfigComboBoxes()
        {
            // Género
            personGender.Items.AddRange(new string[] { "male", "female" });

            // Educación
            personEducation.Items.AddRange(new string[]
            {
            "High School",
            "Associate",
            "Bachelor",
            "Master",
            "Doctorate"
            });

            // Propiedad
            personHomeOwnership.Items.AddRange(new string[]
            {
            "RENT",
            "OWN",
            "MORTGAGE",
            "OTHER"
            });

            // Propósito
            loanIntent.Items.AddRange(new string[]
            {
            "PERSONAL",
            "EDUCATION",
            "MEDICAL",
            "VENTURE",
            "HOMEIMPROVEMENT",
            "DEBTCONSOLIDATION"
            });

            // Impagos anteriores
            previousLoanDefaultsOnFile.Items.AddRange(new string[]
            {
            "Yes",
            "No"
            });

            // Default Input
            personGender.SelectedIndex = 0;
            personEducation.SelectedIndex = 0;
            personHomeOwnership.SelectedIndex = 0;
            loanIntent.SelectedIndex = 0;
            previousLoanDefaultsOnFile.SelectedIndex = 0;
        }

        public void ConfigNumericUpDowns()
        {
            // personIncome
            personIncome.DecimalPlaces = 2;
            personIncome.Maximum = 10000000;
            personIncome.Minimum = 0;

            // personAge
            personAge.Minimum = 18;
            personAge.Maximum = 150;
            personAge.DecimalPlaces = 0;

            // personCreditHistoricalLength
            personCreditHistoricalLength.Minimum = 0;
            personCreditHistoricalLength.Maximum = 30;
            personCreditHistoricalLength.DecimalPlaces = 0;

            // personYearsOfEmploymentExperience
            personYearsOfEmploymentExperience.Minimum = 0;
            personYearsOfEmploymentExperience.Maximum = 130;
            personYearsOfEmploymentExperience.DecimalPlaces = 0;

            // loanInterestRate
            loanInterestRate.Minimum = 0;
            loanInterestRate.Maximum = 20;
            loanInterestRate.DecimalPlaces = 2;

            // loanAmount
            loanAmount.Minimum = 0;
            loanAmount.Maximum = 35000;
            loanAmount.DecimalPlaces = 2;

            // loanPercentIncome
            loanPercentIncome.Minimum = 0;
            loanPercentIncome.Maximum = 1;
            loanPercentIncome.DecimalPlaces = 2;
        }

        public List<NamedOnnxValue> OnnxValues()
        {
            // Preparar los datos de entrada (Usando el modelo de ONNX loan_model.onnx)
            // Dimensiones [1, 1] significa: 1 registro, 1 valor por característica.
            var inputs = new List<NamedOnnxValue>
                {
                    // --- Variables Numéricas (Float y Int64) ---
                    NamedOnnxValue.CreateFromTensor("person_age", new DenseTensor<float>(new float[] { (float)personAge.Value }, new int[] { 1, 1 })),
                    NamedOnnxValue.CreateFromTensor("person_income", new DenseTensor<float>(new float[] { (float)personIncome.Value }, new int[] { 1, 1 })),
                    NamedOnnxValue.CreateFromTensor("person_emp_exp", new DenseTensor<Int64>(new Int64[] { (Int64)personYearsOfEmploymentExperience.Value }, new int[] { 1, 1 })),
                    NamedOnnxValue.CreateFromTensor("loan_amnt", new DenseTensor<float>(new float[] { (float)loanAmount.Value }, new int[] { 1, 1 })),
                    NamedOnnxValue.CreateFromTensor("loan_int_rate", new DenseTensor<float>(new float[] { (float)loanInterestRate.Value }, new int[] { 1, 1 })),
                    NamedOnnxValue.CreateFromTensor("loan_percent_income", new DenseTensor<float>(new float[] { (float)loanPercentIncome.Value }, new int[] { 1, 1 })),
                    NamedOnnxValue.CreateFromTensor("cb_person_cred_hist_length", new DenseTensor<float>(new float[] { (float)personCreditHistoricalLength.Value }, new int[] { 1, 1 })),

                    // --- Variables Categóricas (String) ---
                    NamedOnnxValue.CreateFromTensor("person_gender", new DenseTensor<string>(new string[] { personGender.Text }, new int[] { 1, 1 })),
                    NamedOnnxValue.CreateFromTensor("person_education", new DenseTensor<string>(new string[] { personEducation.Text }, new int[] { 1, 1 })),
                    NamedOnnxValue.CreateFromTensor("person_home_ownership", new DenseTensor<string>(new string[] { personHomeOwnership.Text }, new int[] { 1, 1 })),
                    NamedOnnxValue.CreateFromTensor("loan_intent", new DenseTensor<string>(new string[] { loanIntent.Text }, new int[] { 1, 1 })),
                    NamedOnnxValue.CreateFromTensor("previous_loan_defaults_on_file", new DenseTensor<string>(new string[] { previousLoanDefaultsOnFile.Text }, new int[] { 1, 1 }))
                };

            return inputs;
        }

        private InferenceSession session_status;
        private InferenceSession session_credit_score;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Leer unos modelo de ONNX
            session_status = new InferenceSession("../../../model/loan_status_model.onnx");
            session_credit_score = new InferenceSession("../../../model/credit_score_model.onnx");

            loanStatus.BackColor = System.Drawing.SystemColors.Control;
            loanStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            loanStatus.Text = " _________________________________________ ";
            puntajeCredito.Text = " ___ ";

            // Configurar cada ComboBox
            ConfigComboBoxes();

            // Configurar cada NumericUpDown
            ConfigNumericUpDowns();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var inputs = OnnxValues();

            // 1. Ejecutar la predicción
            using var results_status = session_status.Run(inputs);
            using var results_credit_score = session_credit_score.Run(inputs);

            // 2. Extraer el resultado
            // El modelo RandomForest de Scikit-Learn exportado a ONNX devuelve primero la etiqueta (0 o 1)
            var prediction_status = results_status.First().AsEnumerable<long>().First();
            int prediction_credit_score = (int)Math.Round(results_credit_score.First().AsEnumerable<float>().First(), 0);

            // 3. Extraer el resultado
            if (prediction_status == 1)
            {
                loanStatus.BackColor = Color.Green;
                loanStatus.ForeColor = Color.White;
                loanStatus.Text = " RESULTADO: PRÉSTAMO APROBADO (1) ";
            }
            else
            {
                loanStatus.BackColor = Color.Red;
                loanStatus.ForeColor = Color.White;
                loanStatus.Text = " RESULTADO: PRÉSTAMO RECHAZADO (0) ";
            }

            switch (prediction_credit_score)
            {
                case int n when n >= 750:
                    puntajeCredito.BackColor = Color.Green;
                    break;
                
                case int n when n >= 700 && n <= 749:
                    puntajeCredito.BackColor = Color.YellowGreen;
                    break;

                case int n when n >= 650 && n <= 699:
                    puntajeCredito.BackColor = Color.Yellow;
                    break;

                case int n when n >= 560 && n <= 649:
                    puntajeCredito.BackColor = Color.Orange;
                    break;

                default:
                    puntajeCredito.BackColor = Color.Red;
                    break;
            }
            puntajeCredito.ForeColor = Color.White;
            puntajeCredito.Text = prediction_credit_score.ToString();

            // 4. Agrega el Task.Delay (ejemplo: 3 segundos = 3000 ms)
            // Esto espera sin congelar la interfaz gráfica
            await Task.Delay(3000);

            // 5. Reiniciar configuración
            loanStatus.BackColor = System.Drawing.SystemColors.Control;
            loanStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            loanStatus.Text = " _________________________________________ ";

            puntajeCredito.Text = " ___ ";
            puntajeCredito.BackColor = System.Drawing.SystemColors.Control;
            puntajeCredito.ForeColor = System.Drawing.SystemColors.ControlText;

        }

        private void puntajeCredito_Click(object sender, EventArgs e)
        {

        }
    }
}
