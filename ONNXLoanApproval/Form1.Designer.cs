namespace ONNXLoanApproval
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonPredict = new Button();
            label1 = new Label();
            title1 = new Label();
            personGender = new ComboBox();
            personEducation = new ComboBox();
            personHomeOwnership = new ComboBox();
            loanIntent = new ComboBox();
            previousLoanDefaultsOnFile = new ComboBox();
            loanStatus = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            title2 = new Label();
            personAge = new NumericUpDown();
            personCreditHistoricalLength = new NumericUpDown();
            personIncome = new NumericUpDown();
            personCreditScore = new NumericUpDown();
            personYearsOfEmploymentExperience = new NumericUpDown();
            loanInterestRate = new NumericUpDown();
            loanAmount = new NumericUpDown();
            loanPercentIncome = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)personAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personCreditHistoricalLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personIncome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personCreditScore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personYearsOfEmploymentExperience).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loanInterestRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loanAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loanPercentIncome).BeginInit();
            SuspendLayout();
            // 
            // buttonPredict
            // 
            buttonPredict.Location = new Point(387, 313);
            buttonPredict.Name = "buttonPredict";
            buttonPredict.Size = new Size(180, 51);
            buttonPredict.TabIndex = 0;
            buttonPredict.Text = "Predecir";
            buttonPredict.UseVisualStyleBackColor = true;
            buttonPredict.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(8, 55);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 2;
            label1.Text = "Edad\r\n";
            // 
            // title1
            // 
            title1.AutoSize = true;
            title1.Font = new Font("Segoe UI", 12F);
            title1.Location = new Point(8, 20);
            title1.Name = "title1";
            title1.Size = new Size(128, 21);
            title1.TabIndex = 3;
            title1.Text = "Datos Personales";
            // 
            // personGender
            // 
            personGender.FormattingEnabled = true;
            personGender.Location = new Point(311, 82);
            personGender.Name = "personGender";
            personGender.Size = new Size(121, 23);
            personGender.TabIndex = 4;
            // 
            // personEducation
            // 
            personEducation.FormattingEnabled = true;
            personEducation.Location = new Point(311, 235);
            personEducation.Name = "personEducation";
            personEducation.Size = new Size(121, 23);
            personEducation.TabIndex = 12;
            // 
            // personHomeOwnership
            // 
            personHomeOwnership.FormattingEnabled = true;
            personHomeOwnership.Location = new Point(311, 264);
            personHomeOwnership.Name = "personHomeOwnership";
            personHomeOwnership.Size = new Size(121, 23);
            personHomeOwnership.TabIndex = 13;
            // 
            // loanIntent
            // 
            loanIntent.FormattingEnabled = true;
            loanIntent.Location = new Point(737, 143);
            loanIntent.Name = "loanIntent";
            loanIntent.Size = new Size(121, 23);
            loanIntent.TabIndex = 14;
            // 
            // previousLoanDefaultsOnFile
            // 
            previousLoanDefaultsOnFile.FormattingEnabled = true;
            previousLoanDefaultsOnFile.Location = new Point(458, 235);
            previousLoanDefaultsOnFile.Name = "previousLoanDefaultsOnFile";
            previousLoanDefaultsOnFile.Size = new Size(121, 23);
            previousLoanDefaultsOnFile.TabIndex = 15;
            // 
            // loanStatus
            // 
            loanStatus.AutoSize = true;
            loanStatus.Font = new Font("Segoe UI", 12F);
            loanStatus.Location = new Point(341, 400);
            loanStatus.Name = "loanStatus";
            loanStatus.Size = new Size(270, 21);
            loanStatus.TabIndex = 16;
            loanStatus.Text = " ____________________________________ ";
            loanStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(8, 84);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 17;
            label2.Text = "Género";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(8, 113);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 18;
            label3.Text = "Salario Anual";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(8, 145);
            label4.Name = "label4";
            label4.Size = new Size(200, 21);
            label4.TabIndex = 18;
            label4.Text = "Años de Experencia Laboral";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(8, 177);
            label5.Name = "label5";
            label5.Size = new Size(138, 21);
            label5.TabIndex = 18;
            label5.Text = "Puntaje de Credito";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(8, 208);
            label6.Name = "label6";
            label6.Size = new Size(275, 21);
            label6.TabIndex = 18;
            label6.Text = "Duracion de Historial Crediticio (Años)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(8, 237);
            label7.Name = "label7";
            label7.Size = new Size(80, 21);
            label7.TabIndex = 19;
            label7.Text = "Educación";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(8, 266);
            label8.Name = "label8";
            label8.Size = new Size(224, 21);
            label8.TabIndex = 20;
            label8.Text = "Estado de Propiedad del Hogar";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(458, 55);
            label9.Name = "label9";
            label9.Size = new Size(65, 21);
            label9.TabIndex = 21;
            label9.Text = "Importe";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(458, 84);
            label10.Name = "label10";
            label10.Size = new Size(119, 21);
            label10.TabIndex = 22;
            label10.Text = "Tarifa de Intéres";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(458, 113);
            label11.Name = "label11";
            label11.Size = new Size(203, 21);
            label11.TabIndex = 23;
            label11.Text = "Porcentaje del Salario Anual";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(458, 145);
            label12.Name = "label12";
            label12.Size = new Size(77, 21);
            label12.TabIndex = 24;
            label12.Text = "Propósito";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(458, 199);
            label13.Name = "label13";
            label13.Size = new Size(409, 21);
            label13.TabIndex = 25;
            label13.Text = "¿Tiene un indicador de impagos de préstamos anteriores?";
            // 
            // title2
            // 
            title2.AutoSize = true;
            title2.Font = new Font("Segoe UI", 12F);
            title2.Location = new Point(458, 20);
            title2.Name = "title2";
            title2.Size = new Size(152, 21);
            title2.TabIndex = 26;
            title2.Text = "Datos del Préstamos";
            // 
            // personAge
            // 
            personAge.Location = new Point(311, 53);
            personAge.Name = "personAge";
            personAge.Size = new Size(120, 23);
            personAge.TabIndex = 27;
            // 
            // personCreditHistoricalLength
            // 
            personCreditHistoricalLength.Location = new Point(311, 208);
            personCreditHistoricalLength.Name = "personCreditHistoricalLength";
            personCreditHistoricalLength.Size = new Size(120, 23);
            personCreditHistoricalLength.TabIndex = 28;
            // 
            // personIncome
            // 
            personIncome.Location = new Point(312, 111);
            personIncome.Name = "personIncome";
            personIncome.Size = new Size(120, 23);
            personIncome.TabIndex = 29;
            // 
            // personCreditScore
            // 
            personCreditScore.Location = new Point(311, 175);
            personCreditScore.Name = "personCreditScore";
            personCreditScore.Size = new Size(120, 23);
            personCreditScore.TabIndex = 30;
            // 
            // personYearsOfEmploymentExperience
            // 
            personYearsOfEmploymentExperience.Location = new Point(311, 143);
            personYearsOfEmploymentExperience.Name = "personYearsOfEmploymentExperience";
            personYearsOfEmploymentExperience.Size = new Size(120, 23);
            personYearsOfEmploymentExperience.TabIndex = 31;
            // 
            // loanInterestRate
            // 
            loanInterestRate.Location = new Point(737, 82);
            loanInterestRate.Name = "loanInterestRate";
            loanInterestRate.Size = new Size(120, 23);
            loanInterestRate.TabIndex = 32;
            // 
            // loanAmount
            // 
            loanAmount.Location = new Point(737, 53);
            loanAmount.Name = "loanAmount";
            loanAmount.Size = new Size(120, 23);
            loanAmount.TabIndex = 33;
            // 
            // loanPercentIncome
            // 
            loanPercentIncome.Location = new Point(737, 111);
            loanPercentIncome.Name = "loanPercentIncome";
            loanPercentIncome.Size = new Size(120, 23);
            loanPercentIncome.TabIndex = 34;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 461);
            Controls.Add(loanPercentIncome);
            Controls.Add(loanAmount);
            Controls.Add(loanInterestRate);
            Controls.Add(personYearsOfEmploymentExperience);
            Controls.Add(personCreditScore);
            Controls.Add(personIncome);
            Controls.Add(personCreditHistoricalLength);
            Controls.Add(personAge);
            Controls.Add(title2);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(loanStatus);
            Controls.Add(previousLoanDefaultsOnFile);
            Controls.Add(loanIntent);
            Controls.Add(personHomeOwnership);
            Controls.Add(personEducation);
            Controls.Add(personGender);
            Controls.Add(title1);
            Controls.Add(label1);
            Controls.Add(buttonPredict);
            Name = "Form1";
            Text = "Modelo de Predicción de Aprobación de Préstamos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)personAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)personCreditHistoricalLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)personIncome).EndInit();
            ((System.ComponentModel.ISupportInitialize)personCreditScore).EndInit();
            ((System.ComponentModel.ISupportInitialize)personYearsOfEmploymentExperience).EndInit();
            ((System.ComponentModel.ISupportInitialize)loanInterestRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)loanAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)loanPercentIncome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPredict;
        private Label label1;
        private Label title1;
        private Label title2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private NumericUpDown personAge;
        private NumericUpDown personIncome;
        private NumericUpDown personCreditHistoricalLength;
        private NumericUpDown personCreditScore;
        private NumericUpDown personYearsOfEmploymentExperience;
        private NumericUpDown loanInterestRate;
        private NumericUpDown loanAmount;
        private NumericUpDown loanPercentIncome;
        private ComboBox personGender;
        private ComboBox personEducation;
        private ComboBox personHomeOwnership;
        private ComboBox loanIntent;
        private ComboBox previousLoanDefaultsOnFile;
        private Label loanStatus;
    }
}
