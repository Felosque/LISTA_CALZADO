namespace CalzadoProyecto.Dialogos
{
    partial class GUIeliminarCalzado
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
            this.tbxPosicion = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPosicion = new System.Windows.Forms.Label();
            this.SelectorCalzado = new System.Windows.Forms.ComboBox();
            this.btEliminarCalzado = new System.Windows.Forms.Button();
            this.btVistaPrevia = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxPosicion)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(64, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "ELIMINAR CALZADO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxPosicion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPosicion);
            this.groupBox1.Controls.Add(this.SelectorCalzado);
            this.groupBox1.Location = new System.Drawing.Point(27, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 129);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Cuál calzado debería eliminar? ";
            // 
            // tbxPosicion
            // 
            this.tbxPosicion.Location = new System.Drawing.Point(164, 85);
            this.tbxPosicion.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.tbxPosicion.Name = "tbxPosicion";
            this.tbxPosicion.Size = new System.Drawing.Size(114, 20);
            this.tbxPosicion.TabIndex = 18;
            this.tbxPosicion.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Eliminar calzado del:";
            // 
            // txtPosicion
            // 
            this.txtPosicion.AutoSize = true;
            this.txtPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosicion.Location = new System.Drawing.Point(108, 87);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(50, 13);
            this.txtPosicion.TabIndex = 17;
            this.txtPosicion.Text = "Posición:";
            this.txtPosicion.Visible = false;
            // 
            // SelectorCalzado
            // 
            this.SelectorCalzado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectorCalzado.FormattingEnabled = true;
            this.SelectorCalzado.Items.AddRange(new object[] {
            "inicio",
            "medio",
            "final"});
            this.SelectorCalzado.Location = new System.Drawing.Point(214, 33);
            this.SelectorCalzado.Name = "SelectorCalzado";
            this.SelectorCalzado.Size = new System.Drawing.Size(121, 21);
            this.SelectorCalzado.TabIndex = 7;
            this.SelectorCalzado.SelectedIndexChanged += new System.EventHandler(this.SelectorCalzado_SelectedIndexChanged);
            // 
            // btEliminarCalzado
            // 
            this.btEliminarCalzado.Location = new System.Drawing.Point(138, 282);
            this.btEliminarCalzado.Name = "btEliminarCalzado";
            this.btEliminarCalzado.Size = new System.Drawing.Size(145, 34);
            this.btEliminarCalzado.TabIndex = 7;
            this.btEliminarCalzado.Text = "Eliminar Calzado";
            this.btEliminarCalzado.UseVisualStyleBackColor = true;
            this.btEliminarCalzado.Click += new System.EventHandler(this.btEliminarCalzado_Click);
            // 
            // btVistaPrevia
            // 
            this.btVistaPrevia.Location = new System.Drawing.Point(138, 231);
            this.btVistaPrevia.Name = "btVistaPrevia";
            this.btVistaPrevia.Size = new System.Drawing.Size(145, 34);
            this.btVistaPrevia.TabIndex = 9;
            this.btVistaPrevia.Text = "Vista previa del calzado";
            this.btVistaPrevia.UseVisualStyleBackColor = true;
            this.btVistaPrevia.Click += new System.EventHandler(this.btVistaPrevia_Click);
            // 
            // GUIeliminarCalzado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 354);
            this.Controls.Add(this.btVistaPrevia);
            this.Controls.Add(this.btEliminarCalzado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "GUIeliminarCalzado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxPosicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectorCalzado;
        private System.Windows.Forms.Button btEliminarCalzado;
        private System.Windows.Forms.NumericUpDown tbxPosicion;
        private System.Windows.Forms.Label txtPosicion;
        private System.Windows.Forms.Button btVistaPrevia;
    }
}