using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorAplicacion.NetworkCreate
{
    public partial class NetworkCreateForm : Form
    {
        public delegate void onCreatelick(InfectionNetworkParameters args);
        public event onCreatelick SetupFinish;

        private InfectionNetworkParameters arguments;

        public NetworkCreateForm()
        {
            InitializeComponent();
        }

        private bool ValidateInputs()
        {
            bool res = string.IsNullOrEmpty(NameErrorLabel.Text) && string.IsNullOrEmpty(QuantityErrorLabel.Text) && string.IsNullOrEmpty(ConnectivityErrorLabel.Text) && string.IsNullOrEmpty(SeedErrorLabel.Text);
            res = res && !string.IsNullOrEmpty(NameTextbox.Text);
            res = res && !string.IsNullOrEmpty(QuantityTextbox.Text);
            res = res && !string.IsNullOrEmpty(SeederTextbox.Text);
            res = res && !string.IsNullOrEmpty(ConectivityTextbox.Text);

            return res;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                SetupFinish?.Invoke(arguments);
                this.Close();
            }
            else
            {
                CreateErrorLabel.Text = "Verifique que ingreso los datos correctamente.";
            }
            
        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!string.IsNullOrEmpty(textBox.Text))
            {
                NameErrorLabel.Text = string.Empty;
                arguments.Name = textBox.Text;
            }
            
        }

        private void NetworkCreateForm_Load(object sender, EventArgs e)
        {
            arguments = new InfectionNetworkParameters();
        }

        private void QuantityTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            bool valid = int.TryParse(textBox.Text.ToString(), out int val);

            if (string.IsNullOrEmpty(textBox.Text))
            {
                QuantityErrorLabel.Text = string.Empty;
            }

            if (!valid)
            {
                QuantityErrorLabel.Text = "Ingrese un valor entero correcto.";
                return;
            }

            valid = val >= 1;

            if (valid)
            {
                QuantityErrorLabel.Text = string.Empty;
                arguments.NodeQuantity = val;
            }
            else
            {
                QuantityErrorLabel.Text = "Este valor debe ser un entero positivo.";
            }
        }

        private void ConectivityTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            bool valid = double.TryParse(textBox.Text.ToString(), out double val);

            if (string.IsNullOrEmpty(textBox.Text))
            {
                ConnectivityErrorLabel.Text = string.Empty;
                return;
            }

            if (!valid)
            {
                ConnectivityErrorLabel.Text = "Ingrese un valor decimal correcto.";
                return;
            }

            valid = val >= 1 && val <= 10;

            if (valid)
            {
                ConnectivityErrorLabel.Text = string.Empty;
                arguments.ConnectivityFactor = val;
            }
            else
            {
                ConnectivityErrorLabel.Text = "Este valor debe ser entre 1 y 10";
            }
        }

        private void SeederTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            bool valid = uint.TryParse(textBox.Text.ToString(), out uint val);

            if (string.IsNullOrEmpty(textBox.Text))
            {
                SeedErrorLabel.Text = string.Empty;
            }

            if (!valid)
            {
                SeedErrorLabel.Text = "Ingrese un valor numerico natural correcto mayor a 0.";
                return;
            }

            valid = val >= 1;

            if (valid)
            {
                SeedErrorLabel.Text = string.Empty;
                arguments.Seed = val;
            }
            else
            {
                SeedErrorLabel.Text = "Este valor debe ser un entero positivo.";
            }
        }
    }

    public class InfectionNetworkParameters
    {
        public string Name { get; set; }
        public int NodeQuantity { get; set; }
        public double ConnectivityFactor { get; set; }
        public uint Seed { get; set; }
    }
}
