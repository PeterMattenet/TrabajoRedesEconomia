using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorAplicacion.Setup
{
    public partial class SetupControl : UserControl
    {
        public delegate void onFinishClick(SetupControl setupControl, SetupInfoArgs args);
        public event onFinishClick SetupFinish;

        public SetupControl()
        {
            InitializeComponent();
        }

        private void InitializeBtn_Click(object sender, EventArgs e)
        {
            SetupInfoArgs arguments = new SetupInfoArgs() { };

            SetupFinish?.Invoke(this, arguments);
        }

        private void SetupControl_Load(object sender, EventArgs e)
        {

        }
    }
}
