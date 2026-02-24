# 🏦 ONNX Loan Approval Predictor (C# WinForms)

Esta es una aplicación de escritorio desarrollada en **C# (.NET Windows Forms)** que utiliza un modelo de Machine Learning pre-entrenado para predecir si la solicitud de un préstamo bancario será **aprobada** o **rechazada**. 

El proyecto demuestra la interoperabilidad de los modelos de Machine Learning al cargar un pipeline de *Scikit-Learn* (Random Forest) entrenado en Python y exportado al formato estándar **ONNX** para ejecutar inferencia nativa en un entorno de C#.

## ✨ Características Principales

* **Carga de Modelo Serializado:** La aplicación utiliza `Microsoft.ML.OnnxRuntime` para cargar el modelo `loan_model.onnx` de forma adecuada.
* **Inferencia:** Ejecución de predicciones en tiempo real utilizando C# y el ecosistema .NET.
* **Interfaz Gráfica y Validación:** Implementación de una GUI amigable e intuitiva. Se reemplazaron las entradas de texto libre por controles estrictos (`ComboBox` para variables categóricas y `NumericUpDown` para numéricas) garantizando la **validación de entrada** antes de enviarla al tensor.
* **UI Responsiva:** El botón de predicción implementa programación asíncrona (`async/await Task.Delay`) para mostrar el resultado visualmente durante 3 segundos sin congelar la interfaz de usuario.

## 🛠️ Requisitos Previos

Para ejecutar este proyecto en tu máquina local, necesitarás:
* [Visual Studio 2022](https://visualstudio.microsoft.com/es/) (con la carga de trabajo de "Desarrollo de escritorio de .NET").
* .NET 6.0 o superior.
* El paquete NuGet `Microsoft.ML.OnnxRuntime`.

## 🚀 Instalación y Uso

1. **Clona el repositorio** en tu máquina local.
2. Abre la solución (`ONNXLoanApproval.sln`) en Visual Studio.
3. Asegúrate de que el archivo `loan_model.onnx` se encuentre en la ruta esperada por el código o ajusta la ruta en el método `Form1_Load` (por defecto busca en `../../../model/loan_model.onnx` relativo al ejecutable).
4. Compila y ejecuta el proyecto (F5).

## 🧪 Datos de Prueba

Para comprobar el correcto funcionamiento de la inferencia, puedes utilizar los siguientes perfiles de prueba extraídos del conjunto de datos original:

### Caso 1: Préstamo Aprobado (Resultado: 1) 🟢
* **Age:** 22
* **Income:** 71948.00
* **Emp. Exp:** 0
* **Loan Amount:** 35000.00
* **Interest Rate:** 16.02
* **Percent Income:** 0.49
* **Credit Hist. Length:** 3
* **Credit Score:** 561
* **Gender:** female
* **Education:** Master
* **Home Ownership:** RENT
* **Intent:** PERSONAL
* **Defaults on file:** No

### Caso 2: Préstamo Rechazado (Resultado: 0) 🔴
* **Age:** 21
* **Income:** 12282.00
* **Emp. Exp:** 0
* **Loan Amount:** 1000.00
* **Interest Rate:** 11.14
* **Percent Income:** 0.08
* **Credit Hist. Length:** 2
* **Credit Score:** 504
* **Gender:** female
* **Education:** High School
* **Home Ownership:** OWN
* **Intent:** EDUCATION
* **Defaults on file:** Yes

## 📂 Estructura del Código

* `Form1.cs`: Contiene la lógica principal. Configura las opciones predeterminadas de la interfaz gráfica, mapea las entradas del usuario a un `DenseTensor` multidimensional requerido por ONNX, ejecuta la sesión de inferencia y maneja la actualización visual de los resultados.
