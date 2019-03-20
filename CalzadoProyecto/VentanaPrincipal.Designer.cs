namespace CalzadoProyecto
{
    partial class VentanaPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarListaDeCalzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaDeArchivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirCalzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorPosiciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarRutaDeArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.rutaGuardar = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.volcarRegistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(145, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "INGENIERÍA DE SISTEMAS";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.calzadoToolStripMenuItem,
            this.sistemaDeArchivosToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.archivoToolStripMenuItem.Text = "Aplicación";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // calzadoToolStripMenuItem
            // 
            this.calzadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.mostrarListaDeCalzadoToolStripMenuItem});
            this.calzadoToolStripMenuItem.Name = "calzadoToolStripMenuItem";
            this.calzadoToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.calzadoToolStripMenuItem.Text = "Calzado Lista";
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.insertarToolStripMenuItem.Text = "Añadir Calzado";
            this.insertarToolStripMenuItem.Click += new System.EventHandler(this.insertarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar Calzado";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.buscarToolStripMenuItem.Text = "Buscar/Actualizar Calzado";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // mostrarListaDeCalzadoToolStripMenuItem
            // 
            this.mostrarListaDeCalzadoToolStripMenuItem.Name = "mostrarListaDeCalzadoToolStripMenuItem";
            this.mostrarListaDeCalzadoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.mostrarListaDeCalzadoToolStripMenuItem.Text = "Mostrar lista de calzado";
            this.mostrarListaDeCalzadoToolStripMenuItem.Click += new System.EventHandler(this.mostrarListaDeCalzadoToolStripMenuItem_Click);
            // 
            // sistemaDeArchivosToolStripMenuItem
            // 
            this.sistemaDeArchivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirCalzadoToolStripMenuItem,
            this.buscarPorPosiciónToolStripMenuItem,
            this.editarRegistroToolStripMenuItem,
            this.borrarRegistroToolStripMenuItem,
            this.cargarArchivoToolStripMenuItem,
            this.volcarRegistrosToolStripMenuItem,
            this.guardarArchivoToolStripMenuItem});
            this.sistemaDeArchivosToolStripMenuItem.Name = "sistemaDeArchivosToolStripMenuItem";
            this.sistemaDeArchivosToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.sistemaDeArchivosToolStripMenuItem.Text = "Calzado Archivo";
            // 
            // añadirCalzadoToolStripMenuItem
            // 
            this.añadirCalzadoToolStripMenuItem.Name = "añadirCalzadoToolStripMenuItem";
            this.añadirCalzadoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.añadirCalzadoToolStripMenuItem.Text = "Añadir calzado";
            this.añadirCalzadoToolStripMenuItem.Click += new System.EventHandler(this.añadirCalzadoToolStripMenuItem_Click);
            // 
            // buscarPorPosiciónToolStripMenuItem
            // 
            this.buscarPorPosiciónToolStripMenuItem.Name = "buscarPorPosiciónToolStripMenuItem";
            this.buscarPorPosiciónToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.buscarPorPosiciónToolStripMenuItem.Text = "Buscar registro";
            this.buscarPorPosiciónToolStripMenuItem.Click += new System.EventHandler(this.buscarPorPosiciónToolStripMenuItem_Click);
            // 
            // editarRegistroToolStripMenuItem
            // 
            this.editarRegistroToolStripMenuItem.Name = "editarRegistroToolStripMenuItem";
            this.editarRegistroToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.editarRegistroToolStripMenuItem.Text = "Editar registro";
            this.editarRegistroToolStripMenuItem.Click += new System.EventHandler(this.editarRegistroToolStripMenuItem_Click);
            // 
            // borrarRegistroToolStripMenuItem
            // 
            this.borrarRegistroToolStripMenuItem.Name = "borrarRegistroToolStripMenuItem";
            this.borrarRegistroToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.borrarRegistroToolStripMenuItem.Text = "Borrar registro";
            this.borrarRegistroToolStripMenuItem.Click += new System.EventHandler(this.borrarRegistroToolStripMenuItem_Click);
            // 
            // cargarArchivoToolStripMenuItem
            // 
            this.cargarArchivoToolStripMenuItem.Name = "cargarArchivoToolStripMenuItem";
            this.cargarArchivoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cargarArchivoToolStripMenuItem.Text = "Ver registros";
            this.cargarArchivoToolStripMenuItem.Click += new System.EventHandler(this.cargarArchivoToolStripMenuItem_Click);
            // 
            // guardarArchivoToolStripMenuItem
            // 
            this.guardarArchivoToolStripMenuItem.Name = "guardarArchivoToolStripMenuItem";
            this.guardarArchivoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.guardarArchivoToolStripMenuItem.Text = "Guardar registros";
            this.guardarArchivoToolStripMenuItem.Click += new System.EventHandler(this.guardarArchivoToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarRutaDeArchivoToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // modificarRutaDeArchivoToolStripMenuItem
            // 
            this.modificarRutaDeArchivoToolStripMenuItem.Name = "modificarRutaDeArchivoToolStripMenuItem";
            this.modificarRutaDeArchivoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.modificarRutaDeArchivoToolStripMenuItem.Text = "Modificar ruta de archivo";
            this.modificarRutaDeArchivoToolStripMenuItem.Click += new System.EventHandler(this.modificarRutaDeArchivoToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditosToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // creditosToolStripMenuItem
            // 
            this.creditosToolStripMenuItem.Name = "creditosToolStripMenuItem";
            this.creditosToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.creditosToolStripMenuItem.Text = "Creditos";
            this.creditosToolStripMenuItem.Click += new System.EventHandler(this.creditosToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(137, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "LISTA DE CALZADO";
            // 
            // rutaGuardar
            // 
            this.rutaGuardar.FileName = "Seleccionar archivo para guardar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalzadoProyecto.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(201, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 83);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // volcarRegistrosToolStripMenuItem
            // 
            this.volcarRegistrosToolStripMenuItem.Name = "volcarRegistrosToolStripMenuItem";
            this.volcarRegistrosToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.volcarRegistrosToolStripMenuItem.Text = "Volcar registros";
            this.volcarRegistrosToolStripMenuItem.Click += new System.EventHandler(this.volcarRegistrosToolStripMenuItem_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaPrincipal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditosToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarListaDeCalzadoToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog rutaGuardar;
        private System.Windows.Forms.ToolStripMenuItem sistemaDeArchivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorPosiciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirCalzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarRutaDeArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volcarRegistrosToolStripMenuItem;
    }
}

