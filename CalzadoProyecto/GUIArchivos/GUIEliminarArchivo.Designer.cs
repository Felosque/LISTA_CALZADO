namespace CalzadoProyecto.GUIArchivos
{
    partial class GUIEliminarArchivo
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
            this.grpResultados = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbxTipoC = new System.Windows.Forms.ComboBox();
            this.tbxPrecioC = new System.Windows.Forms.NumericUpDown();
            this.tbxTallaC = new System.Windows.Forms.NumericUpDown();
            this.dteFechaC = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbxTexto = new System.Windows.Forms.Label();
            this.dteFechaB = new System.Windows.Forms.DateTimePicker();
            this.SelectorTipoB = new System.Windows.Forms.ComboBox();
            this.tbxNumericoB = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectorCalzadoB = new System.Windows.Forms.ComboBox();
            this.grpResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxPrecioC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTallaC)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxNumericoB)).BeginInit();
            this.SuspendLayout();
            // 
            // grpResultados
            // 
            this.grpResultados.Controls.Add(this.btnEliminar);
            this.grpResultados.Controls.Add(this.btnConfirmar);
            this.grpResultados.Controls.Add(this.btnCancelar);
            this.grpResultados.Controls.Add(this.tbxTipoC);
            this.grpResultados.Controls.Add(this.tbxPrecioC);
            this.grpResultados.Controls.Add(this.tbxTallaC);
            this.grpResultados.Controls.Add(this.dteFechaC);
            this.grpResultados.Controls.Add(this.label6);
            this.grpResultados.Controls.Add(this.label5);
            this.grpResultados.Controls.Add(this.label4);
            this.grpResultados.Controls.Add(this.label3);
            this.grpResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResultados.Location = new System.Drawing.Point(31, 216);
            this.grpResultados.Name = "grpResultados";
            this.grpResultados.Size = new System.Drawing.Size(383, 193);
            this.grpResultados.TabIndex = 13;
            this.grpResultados.TabStop = false;
            this.grpResultados.Text = "Resultados de busqueda";
            this.grpResultados.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(119, 153);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(166, 34);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar Calzado";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.ForeColor = System.Drawing.Color.Green;
            this.btnConfirmar.Location = new System.Drawing.Point(209, 153);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(125, 34);
            this.btnConfirmar.TabIndex = 20;
            this.btnConfirmar.Text = "Confirmar Eliminar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(60, 153);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 34);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar Eliminar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // tbxTipoC
            // 
            this.tbxTipoC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbxTipoC.Enabled = false;
            this.tbxTipoC.FormattingEnabled = true;
            this.tbxTipoC.Items.AddRange(new object[] {
            "Chanclas",
            "Botas",
            "Tacones",
            "Deportivos"});
            this.tbxTipoC.Location = new System.Drawing.Point(119, 30);
            this.tbxTipoC.Name = "tbxTipoC";
            this.tbxTipoC.Size = new System.Drawing.Size(200, 21);
            this.tbxTipoC.TabIndex = 19;
            this.tbxTipoC.Visible = false;
            // 
            // tbxPrecioC
            // 
            this.tbxPrecioC.Enabled = false;
            this.tbxPrecioC.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tbxPrecioC.Location = new System.Drawing.Point(119, 87);
            this.tbxPrecioC.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.tbxPrecioC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbxPrecioC.Name = "tbxPrecioC";
            this.tbxPrecioC.Size = new System.Drawing.Size(200, 20);
            this.tbxPrecioC.TabIndex = 17;
            this.tbxPrecioC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbxPrecioC.Visible = false;
            // 
            // tbxTallaC
            // 
            this.tbxTallaC.Enabled = false;
            this.tbxTallaC.Location = new System.Drawing.Point(119, 59);
            this.tbxTallaC.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.tbxTallaC.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.tbxTallaC.Name = "tbxTallaC";
            this.tbxTallaC.Size = new System.Drawing.Size(200, 20);
            this.tbxTallaC.TabIndex = 16;
            this.tbxTallaC.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.tbxTallaC.Visible = false;
            // 
            // dteFechaC
            // 
            this.dteFechaC.Enabled = false;
            this.dteFechaC.Location = new System.Drawing.Point(119, 116);
            this.dteFechaC.Name = "dteFechaC";
            this.dteFechaC.Size = new System.Drawing.Size(200, 20);
            this.dteFechaC.TabIndex = 10;
            this.dteFechaC.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Talla:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(0, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 38);
            this.label2.TabIndex = 12;
            this.label2.Text = "ELIMINAR CALZADO ARCHIVO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.tbxTexto);
            this.groupBox1.Controls.Add(this.dteFechaB);
            this.groupBox1.Controls.Add(this.SelectorTipoB);
            this.groupBox1.Controls.Add(this.tbxNumericoB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SelectorCalzadoB);
            this.groupBox1.Location = new System.Drawing.Point(31, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 143);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Cómo debería buscar el calzado?";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(135, 111);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 26);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar Calzado";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbxTexto
            // 
            this.tbxTexto.AutoSize = true;
            this.tbxTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTexto.Location = new System.Drawing.Point(108, 76);
            this.tbxTexto.Name = "tbxTexto";
            this.tbxTexto.Size = new System.Drawing.Size(50, 13);
            this.tbxTexto.TabIndex = 21;
            this.tbxTexto.Text = "Posición:";
            this.tbxTexto.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dteFechaB
            // 
            this.dteFechaB.Location = new System.Drawing.Point(164, 73);
            this.dteFechaB.Name = "dteFechaB";
            this.dteFechaB.Size = new System.Drawing.Size(195, 20);
            this.dteFechaB.TabIndex = 20;
            this.dteFechaB.Visible = false;
            // 
            // SelectorTipoB
            // 
            this.SelectorTipoB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectorTipoB.FormattingEnabled = true;
            this.SelectorTipoB.Items.AddRange(new object[] {
            "Chanclas",
            "Botas",
            "Tacones",
            "Deportivos"});
            this.SelectorTipoB.Location = new System.Drawing.Point(164, 73);
            this.SelectorTipoB.Name = "SelectorTipoB";
            this.SelectorTipoB.Size = new System.Drawing.Size(121, 21);
            this.SelectorTipoB.TabIndex = 19;
            // 
            // tbxNumericoB
            // 
            this.tbxNumericoB.Location = new System.Drawing.Point(164, 74);
            this.tbxNumericoB.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.tbxNumericoB.Name = "tbxNumericoB";
            this.tbxNumericoB.Size = new System.Drawing.Size(114, 20);
            this.tbxNumericoB.TabIndex = 18;
            this.tbxNumericoB.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Buscar calzado por:";
            // 
            // SelectorCalzadoB
            // 
            this.SelectorCalzadoB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectorCalzadoB.FormattingEnabled = true;
            this.SelectorCalzadoB.Items.AddRange(new object[] {
            "tipo",
            "talla",
            "precio",
            "posición",
            "fecha"});
            this.SelectorCalzadoB.Location = new System.Drawing.Point(164, 33);
            this.SelectorCalzadoB.Name = "SelectorCalzadoB";
            this.SelectorCalzadoB.Size = new System.Drawing.Size(121, 21);
            this.SelectorCalzadoB.TabIndex = 7;
            this.SelectorCalzadoB.SelectedIndexChanged += new System.EventHandler(this.SelectorCalzadoB_SelectedIndexChanged);
            // 
            // GUIEliminarArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 419);
            this.Controls.Add(this.grpResultados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUIEliminarArchivo";
            this.grpResultados.ResumeLayout(false);
            this.grpResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxPrecioC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTallaC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxNumericoB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpResultados;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox tbxTipoC;
        private System.Windows.Forms.NumericUpDown tbxPrecioC;
        private System.Windows.Forms.NumericUpDown tbxTallaC;
        private System.Windows.Forms.DateTimePicker dteFechaC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label tbxTexto;
        private System.Windows.Forms.DateTimePicker dteFechaB;
        private System.Windows.Forms.ComboBox SelectorTipoB;
        private System.Windows.Forms.NumericUpDown tbxNumericoB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectorCalzadoB;
    }
}