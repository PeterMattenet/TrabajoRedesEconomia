using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimuladorAplicacion.Simulator;

namespace SimuladorAplicacion.Setup
{
    public partial class SetupControl : UserControl
    {
        public delegate void onFinishClick(SetupControl setupControl, SimulatorParameters args);
        public event onFinishClick SetupFinish;
        private SimulatorParameters arguments;

        public SetupControl()
        {
            InitializeComponent();
        }

        private void InitializeBtn_Click(object sender, EventArgs e)
        {
            SetupFinish?.Invoke(this, arguments);
        }

        private void SetupControl_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            TitleLabel.Text = "Bienvenido al Simulador de Epidemias!";

            SubtitleLabel.Text = "Configure los parametros con los cuales realizar sus pruebas, o dejelos vacíos para que se usen los valores por defecto. Luego seleccione la opción" +
                " de \"Visualizar\" para reproducir la animación de una única iteracion del simulador. " +
                "\n\nSi desea generar experimentos," +
                " dirigase a la opción de \"Experimentar\", donde allí podra configurar multiples instancias del simulador para compararlas entre sí. " +
                "Los resultados de estos son promediados antes de ser agregados a una grilla del parámetro que se quiera medir, en función al número de iteración.";

            InfectionRatioText.Text = "Factor de Infeccion. Este valor es un escalar que multiplica la función de probabilidad de infeccion. Debe ser un valor positivo menor o igual a 10." +
                " Por defecto su valor es 4.";

            RecoveryFactorText.Text = "Factor de Recuperabilidad. Este valor es un escalar que multiplica la función de probabilidad de recuperación. Debe ser un valor positivo menor o igual" +
                " a 10. Por defecto su valor es 5.";

            ImmunityDaysText.Text = "Cantidad de días de Inmunidad. Este valor define cuantas iteraciones un nodo pasara en el estado \"Removed\", luego de haber sobrellevado la infección. Durante" +
                " este tiempo, la probabilidad de que este nodo vuelva a infectarse es 0. Por defecto, su valor es 4.";

            VaccineEffText.Text = "Eficiencia de Vacunación. Este valor porcentual define cuan significativo es el impacto de las vacunas en la probabilidad de infeccion. Cuan mayor sea este valor" +
                " más se reduce la probabilidad de contagio.";

            VaccineRatioText.Text = "Proporción de Vacunados. Este valor porcentual configura cuantos nodos serán elegidos al azar para ser vacunados.";

            AtRiskRatioText.Text = "Proporcion de Pacientes de Riesgo. Este valor porcentual fija cuantos nodos serán azarosamente señalizados como nodos en riesgo. Estos nodos luego de ser infectados " +
                "son removidos de la red, ya que no tienen pocibilidad de recuperación.";

            IterationsLabel.Text = "Cantidad de iteraciónes que durara cada una de las simulaciones realizadas en el experimento.";
            
            ExperimentNumberLabel.Text = "Cantidad de experimentos que serán realizados para promediar los resultados.";

            arguments = new SimulatorParameters()
            {
                VaccineEfficiencyRatio = 0.1,
                AtRiskRatio = 0,
                VaccinatedRatio = 0,
                ChiSquaredDistributionDegreesOfFreedom = 7,
                InfectionChiSquaredFactor = 4 * 7 / 10,
                RecoveryChiSquaredFactor = 5 * 3 / 10,
                ChiSquaredRecoveryDistributionDegreesOfFreedom = 7,
                InfectionProbabilities = new List<double>() { 0.2, 0.2, 0.5, 0.4, 0.35, 0.3, 0.2, 0.2, 0.1, 0.1 },
                //RecoveryProbabilities = new List<double>() { 0.05, 0.1, 0.25, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1 },
                RecoveryProbabilities = new List<double>() { 0.05, 0.05, 0.1, 0.2, 0.3, 0.45, 0.6, 0.75, 0.9, 1 },
                DaysOfImmunity = 4
            };

        }

        private void InfectionRatioBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            bool valid = float.TryParse(textBox.Text.ToString(), out float val);

            if (string.IsNullOrEmpty(textBox.Text))
            {
                arguments.InfectionChiSquaredFactor = (double) 4 * 7 / 10;
                InfectionRatioErrorLabel.Text = string.Empty;
                return;
            }

            if (!valid)
            {
                InfectionRatioErrorLabel.Text = "Ingrese un valor decimal correcto.";
                return;
            }

            valid = val >= 0 && val <= 10;

            if (valid)
            {
                InfectionRatioErrorLabel.Text = string.Empty;
                arguments.InfectionChiSquaredFactor = (double) val * 7 / 10;
            }
            else
            {
                InfectionRatioErrorLabel.Text = "Este valor debe ser un decimal positivo entre 0 y 10";
            }
        }

        private void VaccineEfficiencyErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void AtRiskRatioBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            bool valid = double.TryParse(textBox.Text.ToString(), out double val);

            if (string.IsNullOrEmpty(textBox.Text))
            {
                arguments.AtRiskRatio = (double) 0 / 100;
                AtRiskRatioErrorLabel.Text = string.Empty;
                return;
            }

            if (!valid)
            {
                AtRiskRatioErrorLabel.Text = "Ingrese un valor porcentual correcto.";
                return;
            }

            valid = val >= 0 && val <= 100;

            if (valid)
            {
                AtRiskRatioErrorLabel.Text = string.Empty;
                arguments.AtRiskRatio = (double) val / 100;
            }
            else
            {
                AtRiskRatioErrorLabel.Text = "Este valor debe ser un porcentual (0 a 100)";
            }
        }

        private void VaccineRatioBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            bool valid = double.TryParse(textBox.Text.ToString(), out double val);

            if (string.IsNullOrEmpty(textBox.Text))
            {
                arguments.VaccinatedRatio = (double) 0 / 100;
                VaccineRatioErrorLabel.Text = string.Empty;
                return;
            }

            if (!valid)
            {
                VaccineRatioErrorLabel.Text = "Ingrese un valor porcentual correcto.";
                return;
            }

            valid = val >= 0 && val <= 100;

            if (valid)
            {
                VaccineRatioErrorLabel.Text = string.Empty;
                arguments.VaccinatedRatio = (double) val / 100;
            }
            else
            {
                VaccineRatioErrorLabel.Text = "Este valor debe ser un porcentual (0 a 100)";
            }
        }

        private void VaccineEfficiencyBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            bool valid = double.TryParse(textBox.Text.ToString(), out double val);

            if (string.IsNullOrEmpty(textBox.Text))
            {
                arguments.VaccineEfficiencyRatio = (double) (100 - 90) /100;
                VaccineEfficiencyErrorLabel.Text = string.Empty;
                return;
            }

            if (!valid)
            {
                VaccineEfficiencyErrorLabel.Text = "Ingrese un valor porcentual correcto.";
                return;
            }

            valid = val >= 0 && val <= 100;

            if (valid)
            {
                VaccineEfficiencyErrorLabel.Text = string.Empty;
                arguments.VaccineEfficiencyRatio = (double)(100 - val)/100;
            }
            else
            {
                VaccineEfficiencyErrorLabel.Text = "Este valor debe ser un porcentual (0 a 100)";
            }
        }

        private void ImmunityDaysBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            bool valid = int.TryParse(textBox.Text.ToString(), out int val);

            if (string.IsNullOrEmpty(textBox.Text))
            {
                arguments.DaysOfImmunity = 4;
                ImmunityErrorLabel.Text = string.Empty;
                return;
            }

            if (!valid)
            {
                ImmunityErrorLabel.Text = "Ingrese un valor entero correcto.";
                return;
            }

            valid = val >= 0;

            if (valid)
            {
                ImmunityErrorLabel.Text = string.Empty;
                arguments.DaysOfImmunity = val;
            }
            else
            {
                ImmunityErrorLabel.Text = "Este valor debe ser un entero positivo";
            }
        }

        private void RecoveryRatioBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            bool valid = float.TryParse(textBox.Text.ToString(), out float val);

            if (string.IsNullOrEmpty(textBox.Text))
            {
                arguments.RecoveryChiSquaredFactor = (double)4 * 3 / 10;
                RecoveryErrorLabel.Text = string.Empty;
                return;
            }

            if (!valid)
            {
                RecoveryErrorLabel.Text = "Ingrese un valor decimal correcto.";
                return;
            }

            valid = val >= 0 && val <= 10;

            if (valid)
            {
                RecoveryErrorLabel.Text = string.Empty;
                arguments.RecoveryChiSquaredFactor = (double) val * 3 / 10;
            }
            else
            {
                RecoveryErrorLabel.Text = "Este valor debe ser un decimal positivo entre 0 y 10";
            }
        }

        private void InfectionRatioErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ExperimentErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void ImmunityDaysText_Click(object sender, EventArgs e)
        {

        }

        private void VaccineRatioErrorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
