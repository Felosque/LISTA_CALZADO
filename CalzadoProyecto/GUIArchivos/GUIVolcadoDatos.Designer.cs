namespace CalzadoProyecto.GUIArchivos
{
    partial class GUIVolcadoDatos
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCRuta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbRuta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxRutaV = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dialogoPath = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(144, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 38);
            this.label2.TabIndex = 15;
            this.label2.Text = "VOLCAR DATOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCRuta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbRuta);
            this.groupBox1.Location = new System.Drawing.Point(28, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 88);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurar ruta donde se pondrán los datos";
            // 
            // btnCRuta
            // 
            this.btnCRuta.Location = new System.Drawing.Point(423, 38);
            this.btnCRuta.Name = "btnCRuta";
            this.btnCRuta.Size = new System.Drawing.Size(40, 37);
            this.btnCRuta.TabIndex = 14;
            this.btnCRuta.Text = "...";
            this.btnCRuta.UseVisualStyleBackColor = true;
            this.btnCRuta.Click += new System.EventHandler(this.btnCRuta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ruta actual:";
            // 
            // txbRuta
            // 
            this.txbRuta.Enabled = false;
            this.txbRuta.Location = new System.Drawing.Point(39, 47);
            this.txbRuta.Name = "txbRuta";
            this.txbRuta.Size = new System.Drawing.Size(378, 20);
            this.txbRuta.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbxRutaV);
            this.groupBox2.Location = new System.Drawing.Point(28, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 88);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurar ruta donde se sacarán los datos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ruta actual:";
            // 
            // tbxRutaV
            // 
            this.tbxRutaV.Enabled = false;
            this.tbxRutaV.Location = new System.Drawing.Point(39, 47);
            this.tbxRutaV.Name = "tbxRutaV";
            this.tbxRutaV.Size = new System.Drawing.Size(378, 20);
            this.tbxRutaV.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 36);
            this.button2.TabIndex = 15;
            this.button2.Text = "Volcar Datos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GUIVolcadoDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 360);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUIVolcadoDatos";
            this.Load += new System.EventHandler(this.GUIVolcadoDatos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbRuta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxRutaV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog dialogoPath;
    }
}