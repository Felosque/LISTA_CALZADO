namespace CalzadoProyecto.Dialogos
{
    partial class GUIinsertarCalzado
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
            this.label1 = new System.Windows.Forms.Label();
            this.SelectorCalzado = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxTipo = new System.Windows.Forms.ComboBox();
            this.tbxPosicion = new System.Windows.Forms.NumericUpDown();
            this.tbxPrecio = new System.Windows.Forms.NumericUpDown();
            this.tbxTalla = new System.Windows.Forms.NumericUpDown();
            this.txtPosicion = new System.Windows.Forms.Label();
            this.dteFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.msgError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxPosicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTalla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SelectorCalzado);
            this.groupBox1.Location = new System.Drawing.Point(23, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Donde debo poner el nuevo calzado?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insertar calzado en:";
            // 
            // SelectorCalzado
            // 
            this.SelectorCalzado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectorCalzado.FormattingEnabled = true;
            this.SelectorCalzado.Items.AddRange(new object[] {
            "el inicio",
            "el medio",
            "el final"});
            this.SelectorCalzado.Location = new System.Drawing.Point(222, 19);
            this.SelectorCalzado.Name = "SelectorCalzado";
            this.SelectorCalzado.Size = new System.Drawing.Size(121, 21);
            this.SelectorCalzado.TabIndex = 1;
            this.SelectorCalzado.SelectedIndexChanged += new System.EventHandler(this.SelectorCalzado_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxTipo);
            this.groupBox2.Controls.Add(this.tbxPosicion);
            this.groupBox2.Controls.Add(this.tbxPrecio);
            this.groupBox2.Controls.Add(this.tbxTalla);
            this.groupBox2.Controls.Add(this.txtPosicion);
            this.groupBox2.Controls.Add(this.dteFecha);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 177);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Características";
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
            this.tbxTipo.Location = new System.Drawing.Point(119, 30);
            this.tbxTipo.Name = "tbxTipo";
            this.tbxTipo.Size = new System.Drawing.Size(200, 21);
            this.tbxTipo.TabIndex = 19;
            // 
            // tbxPosicion
            // 
            this.tbxPosicion.Location = new System.Drawing.Point(119, 144);
            this.tbxPosicion.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.tbxPosicion.Name = "tbxPosicion";
            this.tbxPosicion.Size = new System.Drawing.Size(200, 20);
            this.tbxPosicion.TabIndex = 18;
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tbxPrecio.Location = new System.Drawing.Point(119, 87);
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
            this.tbxTalla.Location = new System.Drawing.Point(119, 59);
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
            // txtPosicion
            // 
            this.txtPosicion.AutoSize = true;
            this.txtPosicion.Location = new System.Drawing.Point(56, 144);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(50, 13);
            this.txtPosicion.TabIndex = 14;
            this.txtPosicion.Text = "Posición:";
            this.txtPosicion.Visible = false;
            // 
            // dteFecha
            // 
            this.dteFecha.Location = new System.Drawing.Point(119, 116);
            this.dteFecha.Name = "dteFecha";
            this.dteFecha.Size = new System.Drawing.Size(200, 20);
            this.dteFecha.TabIndex = 10;
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
            this.label2.Location = new System.Drawing.Point(56, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "INSERTAR CALZADO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "INSERTAR CALZADO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // msgError
            // 
            this.msgError.AutoSize = true;
            this.msgError.ForeColor = System.Drawing.Color.DarkRed;
            this.msgError.Location = new System.Drawing.Point(29, 334);
            this.msgError.Name = "msgError";
            this.msgError.Size = new System.Drawing.Size(378, 13);
            this.msgError.TabIndex = 6;
            this.msgError.Text = "Nota: Se inserta el calzado a la posición siguiente de la recibida por parametro." +
    "";
            // 
            // GUIinsertarCalzado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 412);
            this.Controls.Add(this.msgError);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUIinsertarCalzado";
            this.Load += new System.EventHandler(this.GUIinsertarCalzado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxPosicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTalla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectorCalzado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtPosicion;
        private System.Windows.Forms.DateTimePicker dteFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown tbxTalla;
        private System.Windows.Forms.NumericUpDown tbxPrecio;
        private System.Windows.Forms.NumericUpDown tbxPosicion;
        private System.Windows.Forms.Label msgError;
        private System.Windows.Forms.ComboBox tbxTipo;
    }
}