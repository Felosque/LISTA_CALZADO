namespace CalzadoProyecto.GUIArchivos
{
    partial class GUIInsertarArchivo
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbxImg = new System.Windows.Forms.PictureBox();
            this.tbxTipo = new System.Windows.Forms.ComboBox();
            this.tbxPrecio = new System.Windows.Forms.NumericUpDown();
            this.tbxTalla = new System.Windows.Forms.NumericUpDown();
            this.dteFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTalla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxId)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Añadir Calzado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "AÑADIR CALZADO ARCHIVO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pbxImg);
            this.groupBox2.Controls.Add(this.tbxTipo);
            this.groupBox2.Controls.Add(this.tbxPrecio);
            this.groupBox2.Controls.Add(this.tbxTalla);
            this.groupBox2.Controls.Add(this.dteFecha);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 178);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Características";
            // 
            // pbxImg
            // 
            this.pbxImg.Image = global::CalzadoProyecto.Properties.Resources.ls_incognito;
            this.pbxImg.Location = new System.Drawing.Point(285, 48);
            this.pbxImg.Name = "pbxImg";
            this.pbxImg.Size = new System.Drawing.Size(100, 82);
            this.pbxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImg.TabIndex = 7;
            this.pbxImg.TabStop = false;
            // 
            // tbxTipo
            // 
            this.tbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbxTipo.FormattingEnabled = true;
            this.tbxTipo.Items.AddRange(new object[] {
            "Chanclas",
            "Botas",
            "Tacones",
            "Deportivos"});
            this.tbxTipo.Location = new System.Drawing.Point(79, 31);
            this.tbxTipo.Name = "tbxTipo";
            this.tbxTipo.Size = new System.Drawing.Size(200, 21);
            this.tbxTipo.TabIndex = 19;
            this.tbxTipo.SelectedIndexChanged += new System.EventHandler(this.tbxTipo_SelectedIndexChanged);
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tbxPrecio.Location = new System.Drawing.Point(79, 88);
            this.tbxPrecio.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.tbxPrecio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(200, 20);
            this.tbxPrecio.TabIndex = 17;
            this.tbxPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbxTalla
            // 
            this.tbxTalla.Location = new System.Drawing.Point(79, 60);
            this.tbxTalla.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.tbxTalla.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.tbxTalla.Name = "tbxTalla";
            this.tbxTalla.Size = new System.Drawing.Size(200, 20);
            this.tbxTalla.TabIndex = 16;
            this.tbxTalla.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // dteFecha
            // 
            this.dteFecha.Location = new System.Drawing.Point(79, 117);
            this.dteFecha.Name = "dteFecha";
            this.dteFecha.Size = new System.Drawing.Size(200, 20);
            this.dteFecha.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Talla:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo:";
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(79, 143);
            this.tbxId.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(200, 20);
            this.tbxId.TabIndex = 21;
            this.tbxId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID:";
            // 
            // GUIInsertarArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Name = "GUIInsertarArchivo";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTalla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbxImg;
        private System.Windows.Forms.ComboBox tbxTipo;
        private System.Windows.Forms.NumericUpDown tbxPrecio;
        private System.Windows.Forms.NumericUpDown tbxTalla;
        private System.Windows.Forms.DateTimePicker dteFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown tbxId;
        private System.Windows.Forms.Label label1;
    }
}