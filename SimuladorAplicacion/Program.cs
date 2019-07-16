using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorAplicacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //create a form 
            SimulatorForm form = new SimulatorForm();
            //create a viewer object 
            
            //show the form 
            form.ShowDialog();

            //form.SuspendLayout();

            //viewer.Graph.FindNode("C").Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
            //form.Controls.Add(viewer);
            //form.ResumeLayout();

            //form.ShowDialog();

        }
    }
}
