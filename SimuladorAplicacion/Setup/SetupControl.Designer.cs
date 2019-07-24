namespace SimuladorAplicacion.Setup
{
    partial class SetupControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InitializeBtn = new System.Windows.Forms.Button();
            this.InfectionRatioBox = new System.Windows.Forms.TextBox();
            this.RecoveryRatioBox = new System.Windows.Forms.TextBox();
            this.ImmunityDaysBox = new System.Windows.Forms.TextBox();
            this.VaccineEfficiencyBox = new System.Windows.Forms.TextBox();
            this.VaccineRatioBox = new System.Windows.Forms.TextBox();
            this.AtRiskRatioBox = new System.Windows.Forms.TextBox();
            this.InfectionRatioErrorLabel = new System.Windows.Forms.Label();
            this.RecoveryErrorLabel = new System.Windows.Forms.Label();
            this.ImmunityErrorLabel = new System.Windows.Forms.Label();
            this.VaccineRatioErrorLabel = new System.Windows.Forms.Label();
            this.VaccineEfficiencyErrorLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.VaccineRatioText = new System.Windows.Forms.Label();
            this.VaccineEffText = new System.Windows.Forms.Label();
            this.ImmunityDaysText = new System.Windows.Forms.Label();
            this.RecoveryFactorText = new System.Windows.Forms.Label();
            this.InfectionRatioText = new System.Windows.Forms.Label();
            this.AtRiskRatioText = new System.Windows.Forms.Label();
            this.AtRiskRatioErrorLabel = new System.Windows.Forms.Label();
            this.IterationsLabel = new System.Windows.Forms.Label();
            this.ExperimentNumberLabel = new System.Windows.Forms.Label();
            this.ExperimentErrorLabel = new System.Windows.Forms.Label();
            this.IterationErrorLabel = new System.Windows.Forms.Label();
            this.ExperimentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InitializeBtn
            // 
            this.InitializeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InitializeBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InitializeBtn.Location = new System.Drawing.Point(301, 566);
            this.InitializeBtn.Name = "InitializeBtn";
            this.InitializeBtn.Size = new System.Drawing.Size(110, 46);
            this.InitializeBtn.TabIndex = 0;
            this.InitializeBtn.Text = "Visualizar";
            this.InitializeBtn.UseVisualStyleBackColor = false;
            this.InitializeBtn.Click += new System.EventHandler(this.InitializeBtn_Click);
            // 
            // InfectionRatioBox
            // 
            this.InfectionRatioBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InfectionRatioBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.InfectionRatioBox.Location = new System.Drawing.Point(301, 42);
            this.InfectionRatioBox.Name = "InfectionRatioBox";
            this.InfectionRatioBox.Size = new System.Drawing.Size(50, 20);
            this.InfectionRatioBox.TabIndex = 1;
            this.InfectionRatioBox.TextChanged += new System.EventHandler(this.InfectionRatioBox_TextChanged);
            // 
            // RecoveryRatioBox
            // 
            this.RecoveryRatioBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RecoveryRatioBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RecoveryRatioBox.Location = new System.Drawing.Point(301, 123);
            this.RecoveryRatioBox.Name = "RecoveryRatioBox";
            this.RecoveryRatioBox.Size = new System.Drawing.Size(50, 20);
            this.RecoveryRatioBox.TabIndex = 2;
            this.RecoveryRatioBox.TextChanged += new System.EventHandler(this.RecoveryRatioBox_TextChanged);
            // 
            // ImmunityDaysBox
            // 
            this.ImmunityDaysBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ImmunityDaysBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ImmunityDaysBox.Location = new System.Drawing.Point(301, 216);
            this.ImmunityDaysBox.Name = "ImmunityDaysBox";
            this.ImmunityDaysBox.Size = new System.Drawing.Size(50, 20);
            this.ImmunityDaysBox.TabIndex = 3;
            this.ImmunityDaysBox.TextChanged += new System.EventHandler(this.ImmunityDaysBox_TextChanged);
            // 
            // VaccineEfficiencyBox
            // 
            this.VaccineEfficiencyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VaccineEfficiencyBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.VaccineEfficiencyBox.Location = new System.Drawing.Point(301, 305);
            this.VaccineEfficiencyBox.Name = "VaccineEfficiencyBox";
            this.VaccineEfficiencyBox.Size = new System.Drawing.Size(50, 20);
            this.VaccineEfficiencyBox.TabIndex = 4;
            this.VaccineEfficiencyBox.TextChanged += new System.EventHandler(this.VaccineEfficiencyBox_TextChanged);
            // 
            // VaccineRatioBox
            // 
            this.VaccineRatioBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VaccineRatioBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.VaccineRatioBox.Location = new System.Drawing.Point(301, 396);
            this.VaccineRatioBox.Name = "VaccineRatioBox";
            this.VaccineRatioBox.Size = new System.Drawing.Size(50, 20);
            this.VaccineRatioBox.TabIndex = 5;
            this.VaccineRatioBox.TextChanged += new System.EventHandler(this.VaccineRatioBox_TextChanged);
            // 
            // AtRiskRatioBox
            // 
            this.AtRiskRatioBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AtRiskRatioBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AtRiskRatioBox.Location = new System.Drawing.Point(301, 486);
            this.AtRiskRatioBox.Name = "AtRiskRatioBox";
            this.AtRiskRatioBox.Size = new System.Drawing.Size(50, 20);
            this.AtRiskRatioBox.TabIndex = 6;
            this.AtRiskRatioBox.TextChanged += new System.EventHandler(this.AtRiskRatioBox_TextChanged);
            // 
            // InfectionRatioErrorLabel
            // 
            this.InfectionRatioErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InfectionRatioErrorLabel.AutoSize = true;
            this.InfectionRatioErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.InfectionRatioErrorLabel.Location = new System.Drawing.Point(780, 42);
            this.InfectionRatioErrorLabel.MaximumSize = new System.Drawing.Size(215, 60);
            this.InfectionRatioErrorLabel.MinimumSize = new System.Drawing.Size(215, 60);
            this.InfectionRatioErrorLabel.Name = "InfectionRatioErrorLabel";
            this.InfectionRatioErrorLabel.Size = new System.Drawing.Size(215, 60);
            this.InfectionRatioErrorLabel.TabIndex = 7;
            this.InfectionRatioErrorLabel.Click += new System.EventHandler(this.InfectionRatioErrorLabel_Click);
            // 
            // RecoveryErrorLabel
            // 
            this.RecoveryErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RecoveryErrorLabel.AutoSize = true;
            this.RecoveryErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.RecoveryErrorLabel.Location = new System.Drawing.Point(780, 121);
            this.RecoveryErrorLabel.MaximumSize = new System.Drawing.Size(215, 60);
            this.RecoveryErrorLabel.MinimumSize = new System.Drawing.Size(215, 60);
            this.RecoveryErrorLabel.Name = "RecoveryErrorLabel";
            this.RecoveryErrorLabel.Size = new System.Drawing.Size(215, 60);
            this.RecoveryErrorLabel.TabIndex = 9;
            // 
            // ImmunityErrorLabel
            // 
            this.ImmunityErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ImmunityErrorLabel.AutoSize = true;
            this.ImmunityErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ImmunityErrorLabel.Location = new System.Drawing.Point(780, 214);
            this.ImmunityErrorLabel.MaximumSize = new System.Drawing.Size(215, 60);
            this.ImmunityErrorLabel.MinimumSize = new System.Drawing.Size(215, 60);
            this.ImmunityErrorLabel.Name = "ImmunityErrorLabel";
            this.ImmunityErrorLabel.Size = new System.Drawing.Size(215, 60);
            this.ImmunityErrorLabel.TabIndex = 10;
            // 
            // VaccineRatioErrorLabel
            // 
            this.VaccineRatioErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VaccineRatioErrorLabel.AutoSize = true;
            this.VaccineRatioErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.VaccineRatioErrorLabel.Location = new System.Drawing.Point(780, 394);
            this.VaccineRatioErrorLabel.MaximumSize = new System.Drawing.Size(215, 60);
            this.VaccineRatioErrorLabel.MinimumSize = new System.Drawing.Size(215, 60);
            this.VaccineRatioErrorLabel.Name = "VaccineRatioErrorLabel";
            this.VaccineRatioErrorLabel.Size = new System.Drawing.Size(215, 60);
            this.VaccineRatioErrorLabel.TabIndex = 11;
            this.VaccineRatioErrorLabel.Click += new System.EventHandler(this.VaccineEfficiencyErrorLabel_Click);
            // 
            // VaccineEfficiencyErrorLabel
            // 
            this.VaccineEfficiencyErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VaccineEfficiencyErrorLabel.AutoSize = true;
            this.VaccineEfficiencyErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.VaccineEfficiencyErrorLabel.Location = new System.Drawing.Point(780, 303);
            this.VaccineEfficiencyErrorLabel.MaximumSize = new System.Drawing.Size(215, 60);
            this.VaccineEfficiencyErrorLabel.MinimumSize = new System.Drawing.Size(215, 60);
            this.VaccineEfficiencyErrorLabel.Name = "VaccineEfficiencyErrorLabel";
            this.VaccineEfficiencyErrorLabel.Size = new System.Drawing.Size(215, 60);
            this.VaccineEfficiencyErrorLabel.TabIndex = 12;
            this.VaccineEfficiencyErrorLabel.Click += new System.EventHandler(this.VaccineRatioErrorLabel_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(13, 12);
            this.TitleLabel.MinimumSize = new System.Drawing.Size(300, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(300, 18);
            this.TitleLabel.TabIndex = 13;
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleLabel.Location = new System.Drawing.Point(13, 45);
            this.SubtitleLabel.MaximumSize = new System.Drawing.Size(250, 320);
            this.SubtitleLabel.MinimumSize = new System.Drawing.Size(250, 320);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(250, 320);
            this.SubtitleLabel.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.BackColor = System.Drawing.Color.GreenYellow;
            this.textBox1.Location = new System.Drawing.Point(16, 486);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.BackColor = System.Drawing.Color.GreenYellow;
            this.textBox2.Location = new System.Drawing.Point(16, 396);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.Visible = false;
            // 
            // VaccineRatioText
            // 
            this.VaccineRatioText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VaccineRatioText.AutoSize = true;
            this.VaccineRatioText.ForeColor = System.Drawing.Color.Black;
            this.VaccineRatioText.Location = new System.Drawing.Point(357, 394);
            this.VaccineRatioText.MaximumSize = new System.Drawing.Size(400, 60);
            this.VaccineRatioText.MinimumSize = new System.Drawing.Size(400, 60);
            this.VaccineRatioText.Name = "VaccineRatioText";
            this.VaccineRatioText.Size = new System.Drawing.Size(400, 60);
            this.VaccineRatioText.TabIndex = 22;
            // 
            // VaccineEffText
            // 
            this.VaccineEffText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VaccineEffText.AutoSize = true;
            this.VaccineEffText.ForeColor = System.Drawing.Color.Black;
            this.VaccineEffText.Location = new System.Drawing.Point(357, 303);
            this.VaccineEffText.MaximumSize = new System.Drawing.Size(400, 60);
            this.VaccineEffText.MinimumSize = new System.Drawing.Size(400, 60);
            this.VaccineEffText.Name = "VaccineEffText";
            this.VaccineEffText.Size = new System.Drawing.Size(400, 60);
            this.VaccineEffText.TabIndex = 21;
            // 
            // ImmunityDaysText
            // 
            this.ImmunityDaysText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ImmunityDaysText.AutoSize = true;
            this.ImmunityDaysText.ForeColor = System.Drawing.Color.Black;
            this.ImmunityDaysText.Location = new System.Drawing.Point(357, 214);
            this.ImmunityDaysText.MaximumSize = new System.Drawing.Size(400, 60);
            this.ImmunityDaysText.MinimumSize = new System.Drawing.Size(400, 60);
            this.ImmunityDaysText.Name = "ImmunityDaysText";
            this.ImmunityDaysText.Size = new System.Drawing.Size(400, 60);
            this.ImmunityDaysText.TabIndex = 20;
            this.ImmunityDaysText.Click += new System.EventHandler(this.ImmunityDaysText_Click);
            // 
            // RecoveryFactorText
            // 
            this.RecoveryFactorText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RecoveryFactorText.AutoSize = true;
            this.RecoveryFactorText.ForeColor = System.Drawing.Color.Black;
            this.RecoveryFactorText.Location = new System.Drawing.Point(357, 121);
            this.RecoveryFactorText.MaximumSize = new System.Drawing.Size(400, 60);
            this.RecoveryFactorText.MinimumSize = new System.Drawing.Size(400, 60);
            this.RecoveryFactorText.Name = "RecoveryFactorText";
            this.RecoveryFactorText.Size = new System.Drawing.Size(400, 60);
            this.RecoveryFactorText.TabIndex = 19;
            // 
            // InfectionRatioText
            // 
            this.InfectionRatioText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InfectionRatioText.AutoSize = true;
            this.InfectionRatioText.ForeColor = System.Drawing.Color.Black;
            this.InfectionRatioText.Location = new System.Drawing.Point(357, 40);
            this.InfectionRatioText.MaximumSize = new System.Drawing.Size(400, 60);
            this.InfectionRatioText.MinimumSize = new System.Drawing.Size(400, 60);
            this.InfectionRatioText.Name = "InfectionRatioText";
            this.InfectionRatioText.Size = new System.Drawing.Size(400, 60);
            this.InfectionRatioText.TabIndex = 18;
            // 
            // AtRiskRatioText
            // 
            this.AtRiskRatioText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AtRiskRatioText.AutoSize = true;
            this.AtRiskRatioText.ForeColor = System.Drawing.Color.Black;
            this.AtRiskRatioText.Location = new System.Drawing.Point(357, 485);
            this.AtRiskRatioText.MaximumSize = new System.Drawing.Size(400, 60);
            this.AtRiskRatioText.MinimumSize = new System.Drawing.Size(400, 60);
            this.AtRiskRatioText.Name = "AtRiskRatioText";
            this.AtRiskRatioText.Size = new System.Drawing.Size(400, 60);
            this.AtRiskRatioText.TabIndex = 24;
            // 
            // AtRiskRatioErrorLabel
            // 
            this.AtRiskRatioErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AtRiskRatioErrorLabel.AutoSize = true;
            this.AtRiskRatioErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.AtRiskRatioErrorLabel.Location = new System.Drawing.Point(780, 485);
            this.AtRiskRatioErrorLabel.MaximumSize = new System.Drawing.Size(215, 60);
            this.AtRiskRatioErrorLabel.MinimumSize = new System.Drawing.Size(215, 60);
            this.AtRiskRatioErrorLabel.Name = "AtRiskRatioErrorLabel";
            this.AtRiskRatioErrorLabel.Size = new System.Drawing.Size(215, 60);
            this.AtRiskRatioErrorLabel.TabIndex = 25;
            // 
            // IterationsLabel
            // 
            this.IterationsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.IterationsLabel.AutoSize = true;
            this.IterationsLabel.ForeColor = System.Drawing.Color.Black;
            this.IterationsLabel.Location = new System.Drawing.Point(70, 396);
            this.IterationsLabel.MaximumSize = new System.Drawing.Size(225, 40);
            this.IterationsLabel.MinimumSize = new System.Drawing.Size(225, 40);
            this.IterationsLabel.Name = "IterationsLabel";
            this.IterationsLabel.Size = new System.Drawing.Size(225, 40);
            this.IterationsLabel.TabIndex = 26;
            this.IterationsLabel.Visible = false;
            // 
            // ExperimentNumberLabel
            // 
            this.ExperimentNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ExperimentNumberLabel.AutoSize = true;
            this.ExperimentNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.ExperimentNumberLabel.Location = new System.Drawing.Point(70, 486);
            this.ExperimentNumberLabel.MaximumSize = new System.Drawing.Size(225, 40);
            this.ExperimentNumberLabel.MinimumSize = new System.Drawing.Size(225, 40);
            this.ExperimentNumberLabel.Name = "ExperimentNumberLabel";
            this.ExperimentNumberLabel.Size = new System.Drawing.Size(225, 40);
            this.ExperimentNumberLabel.TabIndex = 27;
            this.ExperimentNumberLabel.Visible = false;
            // 
            // ExperimentErrorLabel
            // 
            this.ExperimentErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExperimentErrorLabel.AutoSize = true;
            this.ExperimentErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ExperimentErrorLabel.Location = new System.Drawing.Point(70, 538);
            this.ExperimentErrorLabel.MaximumSize = new System.Drawing.Size(215, 25);
            this.ExperimentErrorLabel.MinimumSize = new System.Drawing.Size(215, 25);
            this.ExperimentErrorLabel.Name = "ExperimentErrorLabel";
            this.ExperimentErrorLabel.Size = new System.Drawing.Size(215, 25);
            this.ExperimentErrorLabel.TabIndex = 28;
            this.ExperimentErrorLabel.Visible = false;
            this.ExperimentErrorLabel.Click += new System.EventHandler(this.ExperimentErrorLabel_Click);
            // 
            // IterationErrorLabel
            // 
            this.IterationErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IterationErrorLabel.AutoSize = true;
            this.IterationErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.IterationErrorLabel.Location = new System.Drawing.Point(70, 446);
            this.IterationErrorLabel.MaximumSize = new System.Drawing.Size(215, 25);
            this.IterationErrorLabel.MinimumSize = new System.Drawing.Size(215, 25);
            this.IterationErrorLabel.Name = "IterationErrorLabel";
            this.IterationErrorLabel.Size = new System.Drawing.Size(215, 25);
            this.IterationErrorLabel.TabIndex = 29;
            this.IterationErrorLabel.Visible = false;
            this.IterationErrorLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ExperimentBtn
            // 
            this.ExperimentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExperimentBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.ExperimentBtn.Location = new System.Drawing.Point(16, 566);
            this.ExperimentBtn.Name = "ExperimentBtn";
            this.ExperimentBtn.Size = new System.Drawing.Size(110, 46);
            this.ExperimentBtn.TabIndex = 30;
            this.ExperimentBtn.Text = "Experimentar";
            this.ExperimentBtn.UseVisualStyleBackColor = false;
            this.ExperimentBtn.Click += new System.EventHandler(this.ExperimentBtn_Click);
            // 
            // SetupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExperimentBtn);
            this.Controls.Add(this.IterationErrorLabel);
            this.Controls.Add(this.ExperimentErrorLabel);
            this.Controls.Add(this.ExperimentNumberLabel);
            this.Controls.Add(this.IterationsLabel);
            this.Controls.Add(this.AtRiskRatioErrorLabel);
            this.Controls.Add(this.AtRiskRatioText);
            this.Controls.Add(this.VaccineRatioText);
            this.Controls.Add(this.VaccineEffText);
            this.Controls.Add(this.ImmunityDaysText);
            this.Controls.Add(this.RecoveryFactorText);
            this.Controls.Add(this.InfectionRatioText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.VaccineEfficiencyErrorLabel);
            this.Controls.Add(this.VaccineRatioErrorLabel);
            this.Controls.Add(this.ImmunityErrorLabel);
            this.Controls.Add(this.RecoveryErrorLabel);
            this.Controls.Add(this.InfectionRatioErrorLabel);
            this.Controls.Add(this.AtRiskRatioBox);
            this.Controls.Add(this.VaccineRatioBox);
            this.Controls.Add(this.VaccineEfficiencyBox);
            this.Controls.Add(this.ImmunityDaysBox);
            this.Controls.Add(this.RecoveryRatioBox);
            this.Controls.Add(this.InfectionRatioBox);
            this.Controls.Add(this.InitializeBtn);
            this.Name = "SetupControl";
            this.Size = new System.Drawing.Size(1008, 641);
            this.Load += new System.EventHandler(this.SetupControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InitializeBtn;
        private System.Windows.Forms.TextBox InfectionRatioBox;
        private System.Windows.Forms.TextBox RecoveryRatioBox;
        private System.Windows.Forms.TextBox ImmunityDaysBox;
        private System.Windows.Forms.TextBox VaccineEfficiencyBox;
        private System.Windows.Forms.TextBox VaccineRatioBox;
        private System.Windows.Forms.TextBox AtRiskRatioBox;
        private System.Windows.Forms.Label InfectionRatioErrorLabel;
        private System.Windows.Forms.Label RecoveryErrorLabel;
        private System.Windows.Forms.Label ImmunityErrorLabel;
        private System.Windows.Forms.Label VaccineRatioErrorLabel;
        private System.Windows.Forms.Label VaccineEfficiencyErrorLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label VaccineRatioText;
        private System.Windows.Forms.Label VaccineEffText;
        private System.Windows.Forms.Label ImmunityDaysText;
        private System.Windows.Forms.Label RecoveryFactorText;
        private System.Windows.Forms.Label InfectionRatioText;
        private System.Windows.Forms.Label AtRiskRatioText;
        private System.Windows.Forms.Label AtRiskRatioErrorLabel;
        private System.Windows.Forms.Label IterationsLabel;
        private System.Windows.Forms.Label ExperimentNumberLabel;
        private System.Windows.Forms.Label ExperimentErrorLabel;
        private System.Windows.Forms.Label IterationErrorLabel;
        private System.Windows.Forms.Button ExperimentBtn;
    }
}
