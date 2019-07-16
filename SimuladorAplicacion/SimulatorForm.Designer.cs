namespace SimuladorAplicacion
{
    partial class SimulatorForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button ResetSimulation;
            System.Windows.Forms.Button StopIterate;
            this.button1 = new System.Windows.Forms.Button();
            this.GraphResultsPanel = new System.Windows.Forms.Panel();
            this.Iterate = new System.Windows.Forms.Button();
            this.AnalysisBox = new System.Windows.Forms.RichTextBox();
            this.Graficar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GraphPanel = new System.Windows.Forms.Panel();
            ResetSimulation = new System.Windows.Forms.Button();
            StopIterate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(612, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Graficar Inf";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Graficar_Infecciosidad_Click);
            // 
            // GraphResultsPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.GraphResultsPanel, 3);
            this.GraphResultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GraphResultsPanel.Location = new System.Drawing.Point(503, 138);
            this.GraphResultsPanel.Name = "GraphResultsPanel";
            this.tableLayoutPanel1.SetRowSpan(this.GraphResultsPanel, 5);
            this.GraphResultsPanel.Size = new System.Drawing.Size(294, 219);
            this.GraphResultsPanel.TabIndex = 7;
            // 
            // Iterate
            // 
            this.Iterate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Iterate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Iterate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Iterate.Location = new System.Drawing.Point(512, 5);
            this.Iterate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Iterate.Name = "Iterate";
            this.Iterate.Size = new System.Drawing.Size(76, 35);
            this.Iterate.TabIndex = 2;
            this.Iterate.Text = "Simular";
            this.Iterate.UseVisualStyleBackColor = true;
            this.Iterate.Click += new System.EventHandler(this.Iterate_Click);
            // 
            // ResetSimulation
            // 
            ResetSimulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            ResetSimulation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ResetSimulation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            ResetSimulation.Location = new System.Drawing.Point(712, 5);
            ResetSimulation.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            ResetSimulation.Name = "ResetSimulation";
            ResetSimulation.Size = new System.Drawing.Size(76, 35);
            ResetSimulation.TabIndex = 4;
            ResetSimulation.Text = "Reiniciar";
            ResetSimulation.UseVisualStyleBackColor = true;
            ResetSimulation.Click += new System.EventHandler(this.ResetSimulation_Click);
            // 
            // StopIterate
            // 
            StopIterate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            StopIterate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            StopIterate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            StopIterate.Location = new System.Drawing.Point(612, 5);
            StopIterate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            StopIterate.Name = "StopIterate";
            StopIterate.Size = new System.Drawing.Size(76, 35);
            StopIterate.TabIndex = 3;
            StopIterate.Text = "Detener";
            StopIterate.UseVisualStyleBackColor = true;
            StopIterate.Click += new System.EventHandler(this.StopIterate_Click);
            // 
            // AnalysisBox
            // 
            this.AnalysisBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tableLayoutPanel1.SetColumnSpan(this.AnalysisBox, 3);
            this.AnalysisBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.AnalysisBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnalysisBox.Enabled = false;
            this.AnalysisBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AnalysisBox.Location = new System.Drawing.Point(503, 363);
            this.AnalysisBox.Name = "AnalysisBox";
            this.AnalysisBox.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.AnalysisBox, 2);
            this.AnalysisBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.AnalysisBox.Size = new System.Drawing.Size(294, 84);
            this.AnalysisBox.TabIndex = 5;
            this.AnalysisBox.Text = "Casos Infectados Actualmente: {0}\nCasos Infectados Historico: {0}\nMuertes de Pers" +
    "onas en Riesgo: {0}\nCantidad de días: {0}";
            // 
            // Graficar
            // 
            this.Graficar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Graficar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Graficar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Graficar.Location = new System.Drawing.Point(512, 50);
            this.Graficar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Graficar.Name = "Graficar";
            this.Graficar.Size = new System.Drawing.Size(76, 35);
            this.Graficar.TabIndex = 6;
            this.Graficar.Text = "Graficar Vac";
            this.Graficar.UseVisualStyleBackColor = true;
            this.Graficar.Visible = false;
            this.Graficar.Click += new System.EventHandler(this.Graficar_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(712, 50);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Graficar Ries";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Graficar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.GraphPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AnalysisBox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(StopIterate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(ResetSimulation, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Iterate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.GraphResultsPanel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GraphPanel
            // 
            this.GraphPanel.Location = new System.Drawing.Point(3, 3);
            this.GraphPanel.Name = "GraphPanel";
            this.tableLayoutPanel1.SetRowSpan(this.GraphPanel, 10);
            this.GraphPanel.Size = new System.Drawing.Size(494, 444);
            this.GraphPanel.TabIndex = 1;
            this.GraphPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GraphPanel_MouseClick);
            // 
            // SimulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SimulatorForm";
            this.Text = "Simulador de Epidemias";
            this.Load += new System.EventHandler(this.SimulatorForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel GraphResultsPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Graficar;
        private System.Windows.Forms.Panel GraphPanel;
        private System.Windows.Forms.RichTextBox AnalysisBox;
        private System.Windows.Forms.Button Iterate;
    }
}

