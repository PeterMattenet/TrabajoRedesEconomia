using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimuladorAplicacion.Setup;

namespace SimuladorAplicacion.Simulator
{
    public partial class SimulatorControl : UserControl
    {
        public delegate void onReturnClick(SimulatorControl simControl);
        public event onReturnClick ReturnClick;

        public SimulatorControl()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public void Setup(SetupInfoArgs arguments)
        {

        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            ReturnClick?.Invoke(this);
        }
        
    }
}
