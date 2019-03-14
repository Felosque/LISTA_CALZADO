namespace CalzadoProyecto.GUIArchivos
{
    partial class GUIConfiguracion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbRuta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCRuta = new System.Windows.Forms.Button();
            this.dialogoPath = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCRuta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbRuta);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurar ruta de archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(103, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 38);
            this.label2.TabIndex = 13;
            this.label2.Text = "CONFIGURACIONES";
            // 
            // txbRuta
            // 
            this.txbRuta.Enabled = false;
            this.txbRuta.Location = new System.Drawing.Point(39, 47);
            this.txbRuta.Name = "txbRuta";
            this.txbRuta.Size = new System.Drawing.Size(378, 20);
            this.txbRuta.TabIndex = 0;
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
            // GUIConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 338);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUIConfiguracion";
            this.Load += new System.EventHandler(this.GUIConfiguracion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbRuta;
        private System.Windows.Forms.OpenFileDialog dialogoPath;
    }
}