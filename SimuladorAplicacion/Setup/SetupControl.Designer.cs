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
            this.SuspendLayout();
            // 
            // InitializeBtn
            // 
            this.InitializeBtn.Location = new System.Drawing.Point(370, 341);
            this.InitializeBtn.Name = "InitializeBtn";
            this.InitializeBtn.Size = new System.Drawing.Size(110, 38);
            this.InitializeBtn.TabIndex = 0;
            this.InitializeBtn.Text = "Inicializar";
            this.InitializeBtn.UseVisualStyleBackColor = true;
            this.InitializeBtn.Click += new System.EventHandler(this.InitializeBtn_Click);
            // 
            // SetupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InitializeBtn);
            this.Name = "SetupControl";
            this.Size = new System.Drawing.Size(560, 411);
            this.Load += new System.EventHandler(this.SetupControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InitializeBtn;
    }
}
