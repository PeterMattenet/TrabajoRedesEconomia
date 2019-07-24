using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SimuladorAplicacion.Simulator;
using System.Windows.Forms.DataVisualization.Charting;
using SimuladorAplicacion.NetworkCreate;

namespace SimuladorAplicacion.Experimentation
{
    public partial class ExperimentationControl : UserControl
    {
        public delegate void onReturnClick(ExperimentationControl simControl);
        public event onReturnClick ReturnClick;

        private InfectionSimulator Simulator { get; set; }

        private ExperimentationParameters arguments;

        private List<ExperimentationParameters> experiments = new List<ExperimentationParameters>();

        private System.Windows.Forms.DataVisualization.Charting.Chart InfectionChart;

        private Microsoft.Msagl.GraphViewerGdi.GViewer _formViewer;

        private string[] TextBoxSeries;

        private Thread SimulatorThread;

        private bool InfectionFactorError = false;
        private bool IterationAmountError = false;
        private bool ExperimentAmountError = false;
        private bool RecoveryFactorError = false;
        private bool AtRiskRatioError = false;
        private bool VaccineEfficiencyError = false;
        private bool VaccineRatioError = false;
        private bool ImmunityDaysError = false;

        public ExperimentationControl()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            //if (SimulatorThread != null && SimulatorThread.IsAlive)
            //    SimulatorThread.Abort();

            ReturnClick?.Invoke(this);
        }

        protected override void OnLoad(EventArgs e)
        {
            arguments = new ExperimentationParameters()
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
            SeriesListBox.BackColor = Color.YellowGreen;

            NetworkSelectBox.Text = "Seleccione Red";
            NetworkSelectBox.Items.Add("Red Simple");
            NetworkSelectBox.Items.Add("Red Media");
            NetworkSelectBox.Items.Add("Red Grande");
            NetworkSelectBox.Items.Add("Red Gigante");
            NetworkSelectBox.Items.Add("Red Masiva");
            NetworkSelectBox.Items.Add("Red Gargantua");

            _formViewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();

            Simulator = new InfectionSimulator(new SimulatorParameters());

            _formViewer.Graph = Simulator.SetCurrentNetworkSimulation("Red Simple");

            NetworkSelectBox.SelectedItem = "Red Simple";

            _formViewer.ToolBarIsVisible = false;
            _formViewer.LayoutEditingEnabled = false;
            ////_formViewer.LayoutEditingEnabled = true;
            ////_formViewer.FitGraphBoundingBox();

            //TextBoxAnalysis = ((RichTextBox)this.Controls.Find("AnalysisBox", true).First()).Lines;


            this.SuspendLayout();

            //UpdateAnalysisTextBoxes();

            //_formViewer.MouseClick += GraphPanel_MouseClick;
            _formViewer.Dock = System.Windows.Forms.DockStyle.Fill;

            ////busco panel y agrego el viewer
            var panel = this.Controls.Find("GraphPanel", true).First();
            panel.Dock = DockStyle.Fill;
            panel.Controls.Add(_formViewer);

            //InfectionChart = new Chart();
            //InfectionChart.Series.Clear();

            //var resultsPanel = this.Controls.Find("GraphResultsPanel", true).First();
            //resultsPanel.Controls.Add(InfectionChart);

            //InfectionChart.ChartAreas.Add(new ChartArea());
            //InfectionChart.Legends.Add(new Legend("Infected Per Day"));


            this.ResumeLayout();


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void InfectionRatioBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            bool valid = float.TryParse(textBox.Text.ToString(), out float val);

            if (string.IsNullOrEmpty(textBox.Text))
            {
                InfectionFactorError = false;
                return;
            }

            if (!valid)
            {
                InfectionFactorError = true;
                return;
            }

            valid = val >= 0 && val <= 10;

            if (valid)
            {
                InfectionFactorError = false;
                arguments.InfectionChiSquaredFactor = (double)val * 7 / 10;
            }
            else
            {
                InfectionFactorError = true;
            }
        }

        private void AtRiskRatioBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            bool valid = double.TryParse(textBox.Text.ToString(), out double val);

            if (string.IsNullOrEmpty(textBox.Text))
            {
                AtRiskRatioError = false;
                return;
            }

            if (!valid)
            {
                AtRiskRatioError = true;
                return;
            }

            valid = val >= 0 && val <= 100;

            if (valid)
            {
                AtRiskRatioError = false;
                arguments.AtRiskRatio = (double)val / 100;
            }
            else
            {
                AtRiskRatioError = true;
            }
        }

        private void VaccineRatioBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            bool valid = double.TryParse(textBox.Text.ToString(), out double val);

            if (string.IsNullOrEmpty(textBox.Text))
            {
                VaccineRatioError = false;
                return;
            }

            if (!valid)
            {
                VaccineRatioError = true;
                return;
            }

            valid = val >= 0 && val <= 100;

            if (valid)
            {
                VaccineRatioError = false;
                arguments.VaccinatedRatio = (double)val / 100;
            }
            else
            {
                VaccineRatioError = true;
            }

        }

        private void VaccineEfficiencyBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            bool valid = double.TryParse(textBox.Text.ToString(), out double val);

            if (string.IsNullOrEmpty(textBox.Text))
            {
                VaccineEfficiencyError = false;
                return;
            }

            if (!valid)
            {
                VaccineEfficiencyError = true;
                return;
            }

            valid = val >= 0 && val <= 100;

            if (valid)
            {
                VaccineEfficiencyError = false;
                arguments.VaccineEfficiencyRatio = (double)(100 - val) / 100;
            }
            else
            {
                VaccineEfficiencyError = true;
            }
        }

        private void ImmunityDaysBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            bool valid = int.TryParse(textBox.Text.ToString(), out int val);

            if (string.IsNullOrEmpty(textBox.Text))
            {
                ImmunityDaysError = false;
                return;
            }

            if (!valid)
            {
                ImmunityDaysError = true;
                return;
            }

            valid = val >= 0;

            if (valid)
            {
                ImmunityDaysError = false;
                arguments.DaysOfImmunity = val;
            }
            else
            {
                ImmunityDaysError = true;
            }
        }

        private void RecoveryRatioBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            bool valid = float.TryParse(textBox.Text.ToString(), out float val);

            if (string.IsNullOrEmpty(textBox.Text))
            {
                RecoveryFactorError = false;
                return;
            }

            if (!valid)
            {
                RecoveryFactorError = true;
                return;
            }

            valid = val >= 0 && val <= 10;

            if (valid)
            {
                RecoveryFactorError = false;
                arguments.RecoveryChiSquaredFactor = (double)val * 3 / 10;
            }
            else
            {
                RecoveryFactorError = true;
            }
        }

        private void IterationAmountTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            bool valid = int.TryParse(textBox.Text.ToString(), out int val);

            if (string.IsNullOrEmpty(textBox.Text))
            {
                IterationAmountError = false;
                return;
            }

            if (!valid)
            {
                IterationAmountError = true;
                SeriesInputErrorAmount++;
                return;
            }

            valid = val >= 0;

            if (valid)
            {
                IterationAmountError = false;
                arguments.IterationsAmount = val;
            }
            else
            {
                IterationAmountError = true;
            }
        }

        private void AveragedExperimentsTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            bool valid = int.TryParse(textBox.Text.ToString(), out int val);

            if (string.IsNullOrEmpty(textBox.Text))
            {
                ExperimentAmountError = false;
                return;
            }

            if (!valid)
            {
                ExperimentAmountError = true;
                SeriesInputErrorAmount++;
                return;
            }

            valid = val >= 0;

            if (valid)
            {
                ExperimentAmountError = false;
                arguments.ExperimentAmount = val;
            }
            else
            {
                ExperimentAmountError = true;
            }

        }

        private void FileNameBtn_Click(object sender, EventArgs e)
        {

        }

        private void SeriesNameBtn_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            arguments.ExperimentName = textBox.Text;
        }

        internal void AddNewNetwork(InfectionNetworkParameters parameters)
        {
            NetworkSelectBox.Items.Add(parameters.Name);

            Simulator.CreateNewNetwork(parameters);

            NetworkSelectBox.SelectedItem = parameters.Name;
        }

        private int SeriesInputErrorAmount = 0;

        private bool CheckInvalidControlGroup()
        {
            if (arguments.IsControl)
            {
                return experiments.Any(ex => ex.IsControl);
            }

            return false;
        }

        private void AddSeriesBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                ParametersErrorLabel.Text = "Hay parametros ingresados invalidos.";
                return;
            }

            if (CheckInvalidControlGroup())
            {
                ParametersErrorLabel.Text = "Ya existe una serie de control.";
                return;
            }

            ParametersErrorLabel.Text = string.Empty;

            AddNewSeriesExperiment();

        }

        private bool ValidateInputs()
        {
            bool res = !string.IsNullOrEmpty(InfectionRatioBox.Text);
            res = res && !string.IsNullOrEmpty(RecoveryRatioBox.Text);
            res = res && !string.IsNullOrEmpty(VaccineRatioBox.Text);
            res = res && !string.IsNullOrEmpty(VaccineEfficiencyBox.Text);
            res = res && !string.IsNullOrEmpty(AtRiskRatioBox.Text);
            res = res && !string.IsNullOrEmpty(ImmunityDaysBox.Text);
            res = res && !string.IsNullOrEmpty(AveragedExperimentsTextbox.Text);
            res = res && !string.IsNullOrEmpty(IterationAmountTextbox.Text);
            res = res && !string.IsNullOrEmpty(SeriesNameBtn.Text);

            res = res && !InfectionFactorError;
            res = res && !AtRiskRatioError;
            res = res && !RecoveryFactorError;
            res = res && !ImmunityDaysError;
            res = res && !ExperimentAmountError;
            res = res && !IterationAmountError;
            res = res && !VaccineEfficiencyError;
            res = res && !VaccineRatioError;

            return res;
        }

        private void CrearRedBtn_Click(object sender, EventArgs e)
        {
            NetworkCreateForm form = new NetworkCreateForm();

            form.SetupFinish += AddNewNetwork;

            form.ShowDialog();

        }

        private void NetworkSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            _formViewer.Graph = Simulator.SetCurrentNetworkSimulation(combo.SelectedItem.ToString());
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddNewSeriesExperiment()
        {
            arguments.NetworkKey = NetworkSelectBox.SelectedItem?.ToString();
            experiments.Add(arguments);

            arguments = new ExperimentationParameters() {
                IterationsAmount = arguments.IterationsAmount,
                ExperimentName = arguments.ExperimentName,
                NetworkKey = arguments.NetworkKey,
                IsControl = false,
                DaysOfImmunity = arguments.DaysOfImmunity,
                ExperimentAmount = arguments.ExperimentAmount,
                InfectionChiSquaredFactor = arguments.InfectionChiSquaredFactor,
                RecoveryChiSquaredFactor = arguments.InfectionChiSquaredFactor,
                VaccinatedRatio = arguments.VaccinatedRatio,
                VaccineEfficiencyRatio = arguments.VaccineEfficiencyRatio,
                AtRiskRatio = arguments.AtRiskRatio
            };

            string[] seriesTextboxLines = new string[experiments.Count() + 1];

            seriesTextboxLines[0] = "Series Ingresadas:";

            for (int i = 0; i < experiments.Count(); i++)
            {
                seriesTextboxLines[i + 1] = $"{experiments[i].ExperimentName}";
            }

            IsControlCheck.Checked = false;
            SeriesListBox.Invoke(new Action(() => SeriesListBox.Lines = seriesTextboxLines));
        }

        private List<double> ExperimentControlGroup(ExperimentationParameters exp)
        {
            Simulator.SetParameters(exp);

            List<double> averageInfectedPerDay = new List<double>();

            for (int j = 0; j < exp.IterationsAmount; j++)
            {
                averageInfectedPerDay.Add(0);
            }

            for (int ex = 0; ex < exp.ExperimentAmount; ex++)
            {
                Simulator.ResetSimulation();
                Simulator.SetCurrentNetworkSimulation(exp.NetworkKey);
                Simulator.InfectRandomNode();

                for (int j = 0; j < exp.IterationsAmount; j++)
                {
                    Simulator.RunIteration();

                    SimulationProgressBar.Value = CalculateProgress(0, ex, j);
                }

                var iterationInfectedPerDay = Simulator.GetInfectionAmountHistory();

                for (int j = 0; j < exp.IterationsAmount; j++)
                {
                    averageInfectedPerDay[j] += iterationInfectedPerDay[j];
                }
            }

            for (int j = 0; j < exp.IterationsAmount; j++)
            {
                averageInfectedPerDay[j] = (averageInfectedPerDay[j] / exp.ExperimentAmount);
            }

            return averageInfectedPerDay;
        }

        private void InfectionExperiment_Click(object sender, EventArgs e)
        {

            Chart experimentResultChart = new Chart();

            System.Drawing.Color[] colors = { System.Drawing.Color.ForestGreen, System.Drawing.Color.Gold, System.Drawing.Color.OrangeRed, System.Drawing.Color.DeepSkyBlue, System.Drawing.Color.Black, System.Drawing.Color.Fuchsia, System.Drawing.Color.SaddleBrown, System.Drawing.Color.DimGray, System.Drawing.Color.DarkMagenta, System.Drawing.Color.RosyBrown, System.Drawing.Color.Silver, System.Drawing.Color.Aquamarine };

            SimulationProgressBar.Visible = true;

            var controlGroupInfectedPerDay = new List<double>();


            experimentResultChart.Size = new Size(1024, 800);

            var chartArea = new ChartArea();


            if (experiments.Any(ex => ex.IsControl))
            {
                chartArea.AxisY.LabelStyle.Format = "{0.00}%";
                controlGroupInfectedPerDay = ExperimentControlGroup(experiments.First(ex => ex.IsControl));
            }

            chartArea.AxisY.LabelAutoFitStyle = LabelAutoFitStyles.None;
            chartArea.AxisX.LabelAutoFitStyle = LabelAutoFitStyles.None;
            chartArea.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 15.25F, System.Drawing.FontStyle.Bold);
            chartArea.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 15.25F, System.Drawing.FontStyle.Bold);
            chartArea.IsSameFontSizeForAllAxes = true;

            experimentResultChart.ChartAreas.Add(chartArea);
            experimentResultChart.Legends.Add(new Legend("Infected Per Day"));

            for (int i = 0; i < experiments.Count; i++)
            {
                if (experiments[i].IsControl)
                    continue;

                List<double> averageInfectedPerDay = new List<double>();

                for (int j = 0; j < experiments[i].IterationsAmount; j++)
                {
                    averageInfectedPerDay.Add(0);
                }

                var seriesInfected = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name =  experiments[i].ExperimentName,
                    Color = colors[i],
                    IsVisibleInLegend = true,
                    IsXValueIndexed = true,
                    ChartType = SeriesChartType.Line,
                    Font = new Font(FontFamily.GenericMonospace, 50, System.Drawing.FontStyle.Regular),
                };
                //seriesInfected.Name
                //experimentResultChart.Width = 200;
                //experimentResultChart.Series.Titles
                //seriesInfected.
                experimentResultChart.Series.Add(seriesInfected);

                Simulator.SetParameters(experiments[i]);

                for (int ex = 0; ex < experiments[i].ExperimentAmount; ex++)
                {
                    Simulator.ResetSimulation();
                    Simulator.SetCurrentNetworkSimulation(experiments[i].NetworkKey);
                    Simulator.InfectRandomNode();

                    for (int j = 0; j < experiments[i].IterationsAmount; j++)
                    {
                        Simulator.RunIteration();

                        SimulationProgressBar.Value = CalculateProgress(i, ex, j);
                    }

                    var iterationInfectedPerDay = Simulator.GetInfectionAmountHistory();

                    for (int j = 0; j < experiments[i].IterationsAmount; j++)
                    {
                        averageInfectedPerDay[j] += iterationInfectedPerDay[j];
                    }
                }

                if (experiments.Any(exp => exp.IsControl))
                {
                    for (int j = 0; j < experiments[i].IterationsAmount; j++)
                    {
                        averageInfectedPerDay[j] =  ((averageInfectedPerDay[j] / experiments[i].ExperimentAmount) - controlGroupInfectedPerDay[j]) * 100 / controlGroupInfectedPerDay[j];

                        experimentResultChart.Series.First(s => s.Name == experiments[i].ExperimentName).Points
                            .AddXY(j, averageInfectedPerDay[j]);
                    }
                }
                else
                {
                    for (int j = 0; j < experiments[i].IterationsAmount; j++)
                    {
                        averageInfectedPerDay[j] = (averageInfectedPerDay[j] / experiments[i].ExperimentAmount);

                        experimentResultChart.Series.First(s => s.Name == experiments[i].ExperimentName).Points
                            .AddXY(j, averageInfectedPerDay[j]);
                    }
                }       
               
            }


            experimentResultChart.SaveImage(Environment.CurrentDirectory + $"{FilePathTextbox.Text}.png", ChartImageFormat.Png);

            SimulationProgressBar.Visible = false;

            MessageBox.Show("Se terminaron de guardar los resultados obtenidos");
        }

        private int CalculateProgress(int experimentNumber, int simulatorNumber, int iterationNumber)
        {
            int res = 0;

            for (int i = 0; i < experimentNumber; i++)
            {
                res += experiments[i].IterationsAmount * experiments[i].ExperimentAmount;
            }

            res += iterationNumber;
            
            for(int i = 0; i < simulatorNumber; i++)
            {
                res += experiments[experimentNumber].IterationsAmount;
            }

            res += iterationNumber;

            int totalExperiments = experiments.Sum(exp => exp.IterationsAmount * exp.ExperimentAmount);

            return (res*100) / totalExperiments;
        }

        private void IsControlCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = sender as CheckBox;

            arguments.IsControl = checkbox.Checked;
        }
    }



    internal class ExperimentationParameters : SimulatorParameters
    {
        public ExperimentationParameters()
        {
            ChiSquaredDistributionDegreesOfFreedom = 7;
            ChiSquaredRecoveryDistributionDegreesOfFreedom = 7;
            InfectionProbabilities = new List<double>() { 0.2, 0.2, 0.5, 0.4, 0.35, 0.3, 0.2, 0.2, 0.1, 0.1 };
            RecoveryProbabilities = new List<double>() { 0.05, 0.05, 0.1, 0.2, 0.3, 0.45, 0.6, 0.75, 0.9, 1 };
        }
        public int ExperimentAmount;
        public int IterationsAmount;
        public string NetworkKey;
        public string ExperimentName;
        public bool IsControl;
    }
}
