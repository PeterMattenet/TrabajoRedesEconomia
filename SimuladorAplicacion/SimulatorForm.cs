using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using SimuladorAplicacion.Simulator;
using SimuladorAplicacion.Setup;
using SimuladorAplicacion;
using Accord;
using Color = Microsoft.Msagl.Drawing.Color;
using Accord.Statistics.Distributions.Univariate;
using SimuladorAplicacion.Experimentation;

namespace SimuladorAplicacion
{
    public partial class SimulatorForm : Form
    {
        private SetupControl setupControl;
        private SimulatorControl simControl;
        private ExperimentationControl expControl;

        public SimulatorForm()
        {
            InitializeComponent();
            setupControl = new SetupControl();

            this.Controls.Clear();
            this.Controls.Add(setupControl);

            setupControl.SetupFinish += SetupFinish;
            setupControl.ExperimentationSelect += OpenExperimentationControl;
        }

        private void SetupFinish(SetupControl control, SimulatorParameters arguments)
        {
            control.Dispose();

            simControl = new SimulatorControl();
            simControl.ReturnClick += ReturnSetup;

            simControl.Setup(arguments);
            this.Controls.Clear();
            this.Controls.Add(simControl);

        }

        private void OpenExperimentationControl(SetupControl control)
        {
            control.Dispose();

            expControl = new ExperimentationControl();
            expControl.ReturnClick += ReturnSetup;
            
            this.Controls.Clear();
            this.Controls.Add(expControl);
        }

        private void ReturnSetup(UserControl control)
        {
            control.Dispose();

            setupControl = new SetupControl();
            setupControl.ExperimentationSelect += OpenExperimentationControl;
            setupControl.SetupFinish += SetupFinish;

            this.Controls.Clear();
            this.Controls.Add(setupControl);
        }

        private readonly int infectionTestDays = 100;
        private readonly int experimentsAmount = 1;

        private string[] TextBoxAnalysis;
        private Thread SimulatorThread;

       
        private readonly SimulatorParameters _simulationParameters = new SimulatorParameters()
        {
            VaccineEfficiencyRatio = 0.1,
            AtRiskRatio = 0,
            VaccinatedRatio = 0,
            ChiSquaredDistributionDegreesOfFreedom = 7,
            InfectionChiSquaredFactor = 3,
            ChiSquaredRecoveryDistributionDegreesOfFreedom = 7,
            InfectionProbabilities = new List<double>() { 0.2, 0.2, 0.5, 0.4, 0.35, 0.3, 0.2, 0.2, 0.1, 0.1 },
            //RecoveryProbabilities = new List<double>() { 0.05, 0.1, 0.25, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1 },
            RecoveryProbabilities = new List<double>() { 0.05, 0.05, 0.1, 0.2, 0.3, 0.45, 0.6, 0.75, 0.9, 1 },
            DaysOfImmunity = 4
        };

        private InfectionSimulator Simulator { get; set; }

        private System.Windows.Forms.DataVisualization.Charting.Chart InfectionChart;

        private Microsoft.Msagl.GraphViewerGdi.GViewer _formViewer;

        private void SimulatorForm_Load(object sender, EventArgs e)
        {
            //test();
            //_formViewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();

            //Simulator = new InfectionSimulator(_simulationParameters);

            //_formViewer.Graph = Simulator.SetCurrentNetworkSimulation("Red2");

            //_formViewer.ToolBarIsVisible = false;
            //_formViewer.LayoutEditingEnabled = false;
            //////_formViewer.LayoutEditingEnabled = true;
            //////_formViewer.FitGraphBoundingBox();

            //TextBoxAnalysis = ((RichTextBox)this.Controls.Find("AnalysisBox", true).First()).Lines;


            //this.SuspendLayout();

            //UpdateAnalysisTextBoxes();

            //_formViewer.MouseClick += GraphPanel_MouseClick;
            //_formViewer.Dock = System.Windows.Forms.DockStyle.Fill;

            //////busco panel y agrego el viewer
            //var panel = this.Controls.Find("GraphPanel", true).First();
            //panel.Dock = DockStyle.Fill;
            //panel.Controls.Add(_formViewer);

            //InfectionChart = new Chart();
            //InfectionChart.Series.Clear();

            //var resultsPanel = this.Controls.Find("GraphResultsPanel", true).First();
            //resultsPanel.Controls.Add(InfectionChart);
            //InfectionChart.ChartAreas.Add(new ChartArea());
            //InfectionChart.Legends.Add(new Legend("Infected Per Day"));


            //this.ResumeLayout();


        }


        private void GraphPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (_formViewer.SelectedObject != null && _formViewer.SelectedObject.GetType().Name == "Node")
            {

                Simulator.InfectNode(((Node)_formViewer.SelectedObject).Id);

                _formViewer.Graph = Simulator.GetCurrentGraph();

                UpdateAnalysisTextBoxes();

                InfectionChart.Series.Clear();
                UpdateSimulationGraphs();
            }


        }

        private void Iterate_Simulation()
        {
            while (true)
            {
                _formViewer.Graph = Simulator.RunIteration();

                UpdateAnalysisTextBoxes();

                UpdateSimulationGraphs();

                Thread.Sleep(1000);
            }
        }

        private void UpdateSimulationGraphs()
        {
            if (this.InfectionChart.Series.All(s => s.Name != "InfectedSeries"))
            {
                var seriesInfected = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = "InfectedSeries",
                    Color = System.Drawing.Color.Green,
                    IsVisibleInLegend = false,
                    IsXValueIndexed = true,
                    ChartType = SeriesChartType.Line
                };

                this.InfectionChart.Invoke(new Action<Series>(series => InfectionChart.Series.Add(series)), seriesInfected);
            }

            this.InfectionChart.Invoke(
                new Action<string>(delegate (string seriesName)
                {
                    this.InfectionChart.Series.First(s => s.Name == seriesName).Points
                        .AddXY(Simulator.GetAmountIterations(), Simulator.GetCurrentInfectedNodes());
                    this.InfectionChart.Invalidate();
                }), "InfectedSeries");

        }

        private void UpdateAnalysisTextBoxes()
        {
            var textAnalysisBox = (RichTextBox)this.Controls.Find("AnalysisBox", true).First();

            string[] analysisText = new string[TextBoxAnalysis.Length];

            for (int i = 0; i < TextBoxAnalysis.Length; i++)
            {
                analysisText[i] = string.Copy(TextBoxAnalysis[i]);
            }

            analysisText[0] = string.Format(analysisText[0], Simulator.GetCurrentInfectedNodes());
            analysisText[1] = string.Format(analysisText[1], Simulator.GetHistoricInfectedNodes());
            analysisText[2] = string.Format(analysisText[2], Simulator.GetHospitalizedAtRiskNodes());
            analysisText[3] = string.Format(analysisText[3], Simulator.GetAmountIterations());

            textAnalysisBox.Invoke(new Action(() => textAnalysisBox.Lines = analysisText));
        }


        private void Iterate_Click(object sender, EventArgs e)
        {
            if (SimulatorThread != null && SimulatorThread.IsAlive)
                SimulatorThread.Abort();

            SimulatorThread = new Thread(Iterate_Simulation);
            SimulatorThread.Start();
        }

        private void StopIterate_Click(object sender, EventArgs e)
        {
            if (SimulatorThread != null && SimulatorThread.IsAlive)
                SimulatorThread.Abort();
        }

        private void ResetSimulation_Click(object sender, EventArgs e)
        {
            Simulator.ResetSimulation();
            _formViewer.Graph = Simulator.GetCurrentGraph();
            UpdateAnalysisTextBoxes();
        }

        private void Graficar_Click(object sender, EventArgs e)
        {

            for (int immunityDays = 4; immunityDays < 17; immunityDays += 4)
            {
                List<double> controlGroupInfectedPerDay = new List<double>();

                for (int i = 0; i < infectionTestDays; i++)
                {
                    controlGroupInfectedPerDay.Add(0);
                }

                
                Chart experimentResultChart = new Chart();

                System.Drawing.Color[] colors = { System.Drawing.Color.ForestGreen, System.Drawing.Color.Gold, System.Drawing.Color.OrangeRed, System.Drawing.Color.DeepSkyBlue, System.Drawing.Color.Black, System.Drawing.Color.Fuchsia, System.Drawing.Color.SaddleBrown, System.Drawing.Color.DimGray };

                _simulationParameters.VaccinatedRatio = 0;
                _simulationParameters.DaysOfImmunity = immunityDays;

                for (int k = 0; k < 1; k += 1)
                {
                    _simulationParameters.VaccinatedRatio = ((float)k) / 10;

                    List<double> averageInfectedPerDay = new List<double>();

                    for (int i = 0; i < infectionTestDays; i++)
                    {
                        averageInfectedPerDay.Add(0);
                    }

                    for (int i = 0; i < experimentsAmount; i++)
                    {
                        var testSimulator = new InfectionSimulator(_simulationParameters);
                        testSimulator.SetCurrentNetworkSimulation("Red2");
                        testSimulator.InfectRandomNode();

                        for (int j = 0; j < infectionTestDays; j++)
                        {
                            testSimulator.RunIteration();
                        }

                        var iterationInfectedPerDay = testSimulator.GetInfectionAmountHistory();

                        for (int j = 0; j < infectionTestDays; j++)
                        {
                            averageInfectedPerDay[j] += iterationInfectedPerDay[j];
                        }
                    }

                    for (int j = 0; j < infectionTestDays; j++)
                    {
                        controlGroupInfectedPerDay[j] = averageInfectedPerDay[j] / experimentsAmount;
                        
                    }

                }


                for (int k = 1; k < 6; k += 1)
                {

                    List<double> averageInfectedPerDay = new List<double>();
                    _simulationParameters.VaccinatedRatio = ((float)k) / 10;

                    for (int i = 0; i < infectionTestDays; i++)
                    {
                        averageInfectedPerDay.Add(0);
                    }

                    var seriesInfected = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = $"K = {_simulationParameters.VaccinatedRatio}",
                        Color = colors[k],
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

                    var a = experimentResultChart.Series[0];

                    for (int i = 0; i < experimentsAmount; i++)
                    {
                        var testSimulator = new InfectionSimulator(_simulationParameters);
                        testSimulator.SetCurrentNetworkSimulation("Red2");
                        testSimulator.InfectRandomNode();

                        for (int j = 0; j < infectionTestDays; j++)
                        {
                            testSimulator.RunIteration();
                        }

                        var iterationInfectedPerDay = testSimulator.GetInfectionAmountHistory();

                        for (int j = 0; j < infectionTestDays; j++)
                        {
                            averageInfectedPerDay[j] += iterationInfectedPerDay[j];
                        }
                    }

                    for (int j = 0; j < infectionTestDays; j++)
                    {
                        averageInfectedPerDay[j] = (-1) * ((averageInfectedPerDay[j] / experimentsAmount) - controlGroupInfectedPerDay[j])/ controlGroupInfectedPerDay[j];

                        experimentResultChart.Series.First(s => s.Name == $"K = {_simulationParameters.VaccinatedRatio}").Points
                            .AddXY(j, averageInfectedPerDay[j]);
                    }

                }

                //experimentResultChart.Scale(new SizeF(5, 5));
                experimentResultChart.Size = new Size(1024, 800);

                //experimentResultChart.Series[0].MarkerBorderWidth = 2000;
                var chartArea = new ChartArea();

                chartArea.AxisY.LabelAutoFitStyle = LabelAutoFitStyles.None;
                chartArea.AxisX.LabelAutoFitStyle = LabelAutoFitStyles.None;
                chartArea.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 15.25F, System.Drawing.FontStyle.Bold);
                chartArea.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 15.25F, System.Drawing.FontStyle.Bold);
                chartArea.IsSameFontSizeForAllAxes = true;

                experimentResultChart.ChartAreas.Add(chartArea);
                experimentResultChart.Legends.Add(new Legend("Infected Per Day"));

                experimentResultChart.SaveImage(Environment.CurrentDirectory + $"\\VariarProporcionVacunados{immunityDays}DiasDeInmunidad.png", ChartImageFormat.Png);
            }

            MessageBox.Show("Se terminaron de guardar los resultados obtenidos");
        }

        private void Graficar_Infecciosidad_Click(object sender, EventArgs e)
        {
            for (int immunityDays = 12; immunityDays < 13; immunityDays += 4)
            {
                List<double> averageInfectedPerDay = new List<double>();

                Chart experimentResultChart = new Chart();

                System.Drawing.Color[] colors = { System.Drawing.Color.ForestGreen, System.Drawing.Color.Gold, System.Drawing.Color.OrangeRed, System.Drawing.Color.DeepSkyBlue, System.Drawing.Color.Black, System.Drawing.Color.Fuchsia, System.Drawing.Color.SaddleBrown, System.Drawing.Color.DimGray };

                _simulationParameters.VaccinatedRatio = 0;
                _simulationParameters.DaysOfImmunity = immunityDays;

                for (int k = 6; k < 7; k += 1)
                {
                    _simulationParameters.InfectionChiSquaredFactor = k;

                    for (int i = 0; i < infectionTestDays; i++)
                    {
                        averageInfectedPerDay.Add(0);
                    }

                    var seriesInfected = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = $"K = {k}",
                        Color = colors[k - 1],
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

                    var a = experimentResultChart.Series[0];

                    for (int i = 0; i < experimentsAmount; i++)
                    {
                        var testSimulator = new InfectionSimulator(_simulationParameters);
                        testSimulator.SetCurrentNetworkSimulation("Red2");
                        testSimulator.InfectRandomNode();

                        for (int j = 0; j < infectionTestDays; j++)
                        {
                            testSimulator.RunIteration();
                        }

                        var iterationInfectedPerDay = testSimulator.GetInfectionAmountHistory();

                        for (int j = 0; j < infectionTestDays; j++)
                        {
                            averageInfectedPerDay[j] += iterationInfectedPerDay[j];
                        }
                    }

                    for (int j = 0; j < infectionTestDays; j++)
                    {
                        averageInfectedPerDay[j] = averageInfectedPerDay[j] / experimentsAmount;

                        experimentResultChart.Series.First(s => s.Name == $"K = {k}").Points
                            .AddXY(j, averageInfectedPerDay[j]);
                    }

                }

                //experimentResultChart.Scale(new SizeF(5, 5));
                experimentResultChart.Size = new Size(1024, 800);

                //experimentResultChart.Series[0].MarkerBorderWidth = 2000;
                var chartArea = new ChartArea();

                chartArea.AxisY.LabelAutoFitStyle = LabelAutoFitStyles.None;
                chartArea.AxisX.LabelAutoFitStyle = LabelAutoFitStyles.None;
                chartArea.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 15.25F, System.Drawing.FontStyle.Bold);
                chartArea.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 15.25F, System.Drawing.FontStyle.Bold);
                chartArea.IsSameFontSizeForAllAxes = true;

                experimentResultChart.ChartAreas.Add(chartArea);
                experimentResultChart.Legends.Add(new Legend("Infected Per Day"));

                experimentResultChart.SaveImage(Environment.CurrentDirectory + $"\\EvaluarOscilacionesK6Y{immunityDays}DiasDeInmunidad.png", ChartImageFormat.Png);
            }
            
            MessageBox.Show("Se terminaron de guardar los resultados obtenidos");
        }
    }
}
