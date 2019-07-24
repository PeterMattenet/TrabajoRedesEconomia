namespace SimuladorAplicacion.NetworkCreate
{
    partial class NetworkCreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateBtn = new System.Windows.Forms.Button();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.QuantityTextbox = new System.Windows.Forms.TextBox();
            this.ConectivityTextbox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.ConnectivityLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameErrorLabel = new System.Windows.Forms.Label();
            this.QuantityErrorLabel = new System.Windows.Forms.Label();
            this.ConnectivityErrorLabel = new System.Windows.Forms.Label();
            this.SeederLabel = new System.Windows.Forms.Label();
            this.SeederTextbox = new System.Windows.Forms.TextBox();
            this.SeedErrorLabel = new System.Windows.Forms.Label();
            this.CreateErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CreateBtn.Location = new System.Drawing.Point(401, 181);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(92, 32);
            this.CreateBtn.TabIndex = 0;
            this.CreateBtn.Text = "Agregar";
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // NameTextbox
            // 
            this.NameTextbox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NameTextbox.Location = new System.Drawing.Point(128, 12);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(168, 20);
            this.NameTextbox.TabIndex = 1;
            this.NameTextbox.TextChanged += new System.EventHandler(this.NameTextbox_TextChanged);
            // 
            // QuantityTextbox
            // 
            this.QuantityTextbox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.QuantityTextbox.Location = new System.Drawing.Point(128, 48);
            this.QuantityTextbox.Name = "QuantityTextbox";
            this.QuantityTextbox.Size = new System.Drawing.Size(72, 20);
            this.QuantityTextbox.TabIndex = 2;
            this.QuantityTextbox.TextChanged += new System.EventHandler(this.QuantityTextbox_TextChanged);
            // 
            // ConectivityTextbox
            // 
            this.ConectivityTextbox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ConectivityTextbox.Location = new System.Drawing.Point(128, 83);
            this.ConectivityTextbox.Name = "ConectivityTextbox";
            this.ConectivityTextbox.Size = new System.Drawing.Size(72, 20);
            this.ConectivityTextbox.TabIndex = 3;
            this.ConectivityTextbox.TextChanged += new System.EventHandler(this.ConectivityTextbox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 15);
            this.NameLabel.MinimumSize = new System.Drawing.Size(102, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(102, 13);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Nombre de Red";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(12, 51);
            this.QuantityLabel.MinimumSize = new System.Drawing.Size(102, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(102, 13);
            this.QuantityLabel.TabIndex = 5;
            this.QuantityLabel.Text = "Cantidad Nodos";
            this.QuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConnectivityLabel
            // 
            this.ConnectivityLabel.AutoSize = true;
            this.ConnectivityLabel.Location = new System.Drawing.Point(12, 83);
            this.ConnectivityLabel.MaximumSize = new System.Drawing.Size(110, 0);
            this.ConnectivityLabel.MinimumSize = new System.Drawing.Size(0, 26);
            this.ConnectivityLabel.Name = "ConnectivityLabel";
            this.ConnectivityLabel.Size = new System.Drawing.Size(102, 26);
            this.ConnectivityLabel.TabIndex = 6;
            this.ConnectivityLabel.Text = "Factor Conectividad (1 a 10)";
            this.ConnectivityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(12, 166);
            this.label1.MaximumSize = new System.Drawing.Size(250, 0);
            this.label1.MinimumSize = new System.Drawing.Size(0, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "Planeo agregar otros parametros para configurar la creacion de redes y poder expe" +
    "rimentar sobre ellos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameErrorLabel
            // 
            this.NameErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NameErrorLabel.AutoSize = true;
            this.NameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.NameErrorLabel.Location = new System.Drawing.Point(302, 9);
            this.NameErrorLabel.MaximumSize = new System.Drawing.Size(215, 26);
            this.NameErrorLabel.MinimumSize = new System.Drawing.Size(150, 26);
            this.NameErrorLabel.Name = "NameErrorLabel";
            this.NameErrorLabel.Size = new System.Drawing.Size(150, 26);
            this.NameErrorLabel.TabIndex = 10;
            // 
            // QuantityErrorLabel
            // 
            this.QuantityErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.QuantityErrorLabel.AutoSize = true;
            this.QuantityErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.QuantityErrorLabel.Location = new System.Drawing.Point(206, 48);
            this.QuantityErrorLabel.MaximumSize = new System.Drawing.Size(250, 26);
            this.QuantityErrorLabel.MinimumSize = new System.Drawing.Size(250, 26);
            this.QuantityErrorLabel.Name = "QuantityErrorLabel";
            this.QuantityErrorLabel.Size = new System.Drawing.Size(250, 26);
            this.QuantityErrorLabel.TabIndex = 11;
            // 
            // ConnectivityErrorLabel
            // 
            this.ConnectivityErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ConnectivityErrorLabel.AutoSize = true;
            this.ConnectivityErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ConnectivityErrorLabel.Location = new System.Drawing.Point(206, 86);
            this.ConnectivityErrorLabel.MaximumSize = new System.Drawing.Size(250, 26);
            this.ConnectivityErrorLabel.MinimumSize = new System.Drawing.Size(250, 26);
            this.ConnectivityErrorLabel.Name = "ConnectivityErrorLabel";
            this.ConnectivityErrorLabel.Size = new System.Drawing.Size(250, 26);
            this.ConnectivityErrorLabel.TabIndex = 12;
            // 
            // SeederLabel
            // 
            this.SeederLabel.AutoSize = true;
            this.SeederLabel.Location = new System.Drawing.Point(12, 124);
            this.SeederLabel.MaximumSize = new System.Drawing.Size(100, 0);
            this.SeederLabel.MinimumSize = new System.Drawing.Size(102, 26);
            this.SeederLabel.Name = "SeederLabel";
            this.SeederLabel.Size = new System.Drawing.Size(102, 26);
            this.SeederLabel.TabIndex = 14;
            this.SeederLabel.Text = "Semilla (numero natural)";
            this.SeederLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SeederTextbox
            // 
            this.SeederTextbox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SeederTextbox.Location = new System.Drawing.Point(128, 124);
            this.SeederTextbox.Name = "SeederTextbox";
            this.SeederTextbox.Size = new System.Drawing.Size(72, 20);
            this.SeederTextbox.TabIndex = 13;
            this.SeederTextbox.TextChanged += new System.EventHandler(this.SeederTextbox_TextChanged);
            // 
            // SeedErrorLabel
            // 
            this.SeedErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SeedErrorLabel.AutoSize = true;
            this.SeedErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.SeedErrorLabel.Location = new System.Drawing.Point(206, 127);
            this.SeedErrorLabel.MaximumSize = new System.Drawing.Size(250, 26);
            this.SeedErrorLabel.MinimumSize = new System.Drawing.Size(250, 26);
            this.SeedErrorLabel.Name = "SeedErrorLabel";
            this.SeedErrorLabel.Size = new System.Drawing.Size(250, 26);
            this.SeedErrorLabel.TabIndex = 15;
            // 
            // CreateErrorLabel
            // 
            this.CreateErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateErrorLabel.AutoSize = true;
            this.CreateErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.CreateErrorLabel.Location = new System.Drawing.Point(264, 174);
            this.CreateErrorLabel.MaximumSize = new System.Drawing.Size(130, 39);
            this.CreateErrorLabel.MinimumSize = new System.Drawing.Size(130, 39);
            this.CreateErrorLabel.Name = "CreateErrorLabel";
            this.CreateErrorLabel.Size = new System.Drawing.Size(130, 39);
            this.CreateErrorLabel.TabIndex = 16;
            // 
            // NetworkCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 225);
            this.Controls.Add(this.CreateErrorLabel);
            this.Controls.Add(this.SeedErrorLabel);
            this.Controls.Add(this.SeederLabel);
            this.Controls.Add(this.SeederTextbox);
            this.Controls.Add(this.ConnectivityErrorLabel);
            this.Controls.Add(this.QuantityErrorLabel);
            this.Controls.Add(this.NameErrorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnectivityLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ConectivityTextbox);
            this.Controls.Add(this.QuantityTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.CreateBtn);
            this.Name = "NetworkCreateForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Crear nueva Red";
            this.Load += new System.EventHandler(this.NetworkCreateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox QuantityTextbox;
        private System.Windows.Forms.TextBox ConectivityTextbox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label ConnectivityLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameErrorLabel;
        private System.Windows.Forms.Label QuantityErrorLabel;
        private System.Windows.Forms.Label ConnectivityErrorLabel;
        private System.Windows.Forms.Label SeederLabel;
        private System.Windows.Forms.TextBox SeederTextbox;
        private System.Windows.Forms.Label SeedErrorLabel;
        private System.Windows.Forms.Label CreateErrorLabel;
    }
}