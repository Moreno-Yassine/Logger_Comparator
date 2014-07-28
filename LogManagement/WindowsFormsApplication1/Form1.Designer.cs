namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.KPI = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ApplicationAttribute = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MachineAttribute = new System.Windows.Forms.Label();
            this.ScanKPI = new System.Windows.Forms.Button();
            this.text2 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Appels = new System.Windows.Forms.Label();
            this.ClientsDetectes = new System.Windows.Forms.Label();
            this.ClientsMultiples = new System.Windows.Forms.Label();
            this.NonClients = new System.Windows.Forms.Label();
            this.KPI.SuspendLayout();
            this.SuspendLayout();
            // 
            // KPI
            // 
            this.KPI.Controls.Add(this.NonClients);
            this.KPI.Controls.Add(this.ClientsMultiples);
            this.KPI.Controls.Add(this.ClientsDetectes);
            this.KPI.Controls.Add(this.Appels);
            this.KPI.Controls.Add(this.label5);
            this.KPI.Controls.Add(this.label4);
            this.KPI.Controls.Add(this.label3);
            this.KPI.Controls.Add(this.label2);
            this.KPI.Controls.Add(this.ApplicationAttribute);
            this.KPI.Controls.Add(this.label1);
            this.KPI.Controls.Add(this.MachineAttribute);
            this.KPI.Controls.Add(this.ScanKPI);
            this.KPI.Controls.Add(this.text2);
            this.KPI.Controls.Add(this.text1);
            this.KPI.Location = new System.Drawing.Point(14, 10);
            this.KPI.Name = "KPI";
            this.KPI.Size = new System.Drawing.Size(531, 356);
            this.KPI.TabIndex = 0;
            this.KPI.TabStop = false;
            this.KPI.Text = "KPI";
            this.KPI.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Appels :";
            // 
            // ApplicationAttribute
            // 
            this.ApplicationAttribute.AutoSize = true;
            this.ApplicationAttribute.Location = new System.Drawing.Point(335, 28);
            this.ApplicationAttribute.Name = "ApplicationAttribute";
            this.ApplicationAttribute.Size = new System.Drawing.Size(27, 13);
            this.ApplicationAttribute.TabIndex = 5;
            this.ApplicationAttribute.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Application :";
            // 
            // MachineAttribute
            // 
            this.MachineAttribute.AutoSize = true;
            this.MachineAttribute.Location = new System.Drawing.Point(108, 28);
            this.MachineAttribute.Name = "MachineAttribute";
            this.MachineAttribute.Size = new System.Drawing.Size(27, 13);
            this.MachineAttribute.TabIndex = 3;
            this.MachineAttribute.Text = "N/A";
            // 
            // ScanKPI
            // 
            this.ScanKPI.Location = new System.Drawing.Point(414, 313);
            this.ScanKPI.Name = "ScanKPI";
            this.ScanKPI.Size = new System.Drawing.Size(111, 37);
            this.ScanKPI.TabIndex = 2;
            this.ScanKPI.Text = "Scan KPI";
            this.ScanKPI.UseVisualStyleBackColor = true;
            this.ScanKPI.Click += new System.EventHandler(this.ScanKPI_Click);
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Location = new System.Drawing.Point(31, 75);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(47, 13);
            this.text2.TabIndex = 1;
            this.text2.Text = "Metrics :";
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Location = new System.Drawing.Point(31, 28);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(57, 13);
            this.text1.TabIndex = 0;
            this.text1.Text = "Machine : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Detections :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Detections Multiples :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Detections Négatives :";
            // 
            // Appels
            // 
            this.Appels.AutoSize = true;
            this.Appels.Location = new System.Drawing.Point(266, 118);
            this.Appels.Name = "Appels";
            this.Appels.Size = new System.Drawing.Size(27, 13);
            this.Appels.TabIndex = 10;
            this.Appels.Text = "N/A";
            // 
            // ClientsDetectes
            // 
            this.ClientsDetectes.AutoSize = true;
            this.ClientsDetectes.Location = new System.Drawing.Point(266, 157);
            this.ClientsDetectes.Name = "ClientsDetectes";
            this.ClientsDetectes.Size = new System.Drawing.Size(27, 13);
            this.ClientsDetectes.TabIndex = 11;
            this.ClientsDetectes.Text = "N/A";
            // 
            // ClientsMultiples
            // 
            this.ClientsMultiples.AutoSize = true;
            this.ClientsMultiples.Location = new System.Drawing.Point(266, 192);
            this.ClientsMultiples.Name = "ClientsMultiples";
            this.ClientsMultiples.Size = new System.Drawing.Size(27, 13);
            this.ClientsMultiples.TabIndex = 12;
            this.ClientsMultiples.Text = "N/A";
            // 
            // NonClients
            // 
            this.NonClients.AutoSize = true;
            this.NonClients.Location = new System.Drawing.Point(266, 228);
            this.NonClients.Name = "NonClients";
            this.NonClients.Size = new System.Drawing.Size(27, 13);
            this.NonClients.TabIndex = 13;
            this.NonClients.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 378);
            this.Controls.Add(this.KPI);
            this.Name = "Form1";
            this.Text = "WS.QDS.KpiCenter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KPI.ResumeLayout(false);
            this.KPI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox KPI;
        private System.Windows.Forms.Button ScanKPI;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label text1;
        public System.Windows.Forms.Label MachineAttribute;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label ApplicationAttribute;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label NonClients;
        public System.Windows.Forms.Label ClientsMultiples;
        public System.Windows.Forms.Label ClientsDetectes;
        public System.Windows.Forms.Label Appels;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

