using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = Microsoft.Msagl.Drawing.Color;

namespace SimuladorAplicacion
{
    public partial class SimulatorForm : Form
    {
        public SimulatorForm()
        {
            InitializeComponent();
        }

        private Microsoft.Msagl.GraphViewerGdi.GViewer _formViewer;

        private void SimulatorForm_Load(object sender, EventArgs e)
        {
            _formViewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();

            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //create the graph content 
            graph.AddEdge("A", "B");
            graph.AddEdge("B", "C");
            graph.AddEdge("A", "C").Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
            graph.FindNode("A").Attr.FillColor = Microsoft.Msagl.Drawing.Color.Magenta;
            graph.FindNode("B").Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;
            Microsoft.Msagl.Drawing.Node c = graph.FindNode("C");
            c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
            c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
            //bind the graph to the viewer 
            _formViewer.Graph = graph;
            //associate the viewer with the form 

            this.SuspendLayout();

            _formViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            var panel = this.Controls.Find("GraphPanel", true).First();
            panel.Controls.Add(_formViewer);

            this.ResumeLayout();

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            var panel = this.Controls.Find("GraphPanel", true).First();

            panel.Controls.Clear();

            _formViewer.Graph.FindNode("C").Attr.FillColor = Color.DarkBlue;
            panel.Controls.Add(_formViewer);

            this.ResumeLayout();

        }
    }
}
