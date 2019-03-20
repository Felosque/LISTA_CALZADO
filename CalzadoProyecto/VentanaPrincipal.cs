using CalzadoProyecto.Dialogos;
using CalzadoProyecto.Exepciones;
using CalzadoProyecto.GUIArchivos;
using CalzadoProyecto.servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalzadoProyecto
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIinsertarCalzado ven = new GUIinsertarCalzado();
            ven.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIeliminarCalzado ven = new GUIeliminarCalzado();
            ven.Show();
        }

        private void mostrarListaDeCalzadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIListaCalzado ven = new GUIListaCalzado();
            ven.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIbuscarCalzado ven = new GUIbuscarCalzado();
            ven.Show();
        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proyecto creado por: \n\n-Andres Felipe Novoa\n-Luis Felipe Londoño Medina.\n\n© Todos los derechos reservados ©");
        }

        private void guardarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rutaGuardar.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            rutaGuardar.FilterIndex = 1;
            rutaGuardar.Multiselect = false;

            try
            {
                if (rutaGuardar.ShowDialog() == DialogResult.OK)
                {
                    String ruta = rutaGuardar.FileName;
                    Servicios.guardarCalzados(ruta);
                }
            }
            catch (MensajeExepcion ef)
            {
                MessageBox.Show(ef.darExepcion());
            }
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Servicios.darPath() != "") { 
                GUIVerCalzadosArchivo ven = new GUIVerCalzadosArchivo();
                ven.Show();
            }
            else
            {
                MessageBox.Show("¡Tiene que configurar primero el archivo donde trabajara la aplicación!  \n\nVaya a la sección de configuraciones y configure el path de la aplicación.");
            }
        }

        private void buscarPorPosiciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Servicios.darPath() != "")
            {
                GUIBuscarArchivo ven = new GUIBuscarArchivo();
                ven.Show();
            }
            else
            {
                MessageBox.Show("¡Tiene que configurar primero el archivo donde trabajara la aplicación!  \n\nVaya a la sección de configuraciones y configure el path de la aplicación.");
            }
        }

        private void añadirCalzadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Servicios.darPath() != "")
            {
                GUIInsertarArchivo ven = new GUIInsertarArchivo();
                ven.Show();
            }
            else
            {
                MessageBox.Show("¡Tiene que configurar primero el archivo donde trabajara la aplicación!  \n\nVaya a la sección de configuraciones y configure el path de la aplicación.");
            }
        }

        private void borrarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Servicios.darPath() != "")
            {
                GUIEliminarArchivo ven = new GUIEliminarArchivo();
                ven.Show();
            }
            else
            {
                MessageBox.Show("¡Tiene que configurar primero el archivo donde trabajara la aplicación!  \n\nVaya a la sección de configuraciones y configure el path de la aplicación.");
            }
        }

        private void editarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Servicios.darPath() != "")
            {
                GUIModificarArchivo ven = new GUIModificarArchivo();
                ven.Show();
            }
            else
            {
                MessageBox.Show("¡Tiene que configurar primero el archivo donde trabajara la aplicación!  \n\nVaya a la sección de configuraciones y configure el path de la aplicación.");
            }
        }

        private void modificarRutaDeArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIConfiguracion ven = new GUIConfiguracion();
            ven.Show();
        }

        private void volcarRegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Servicios.darPath() != "")
            {
                GUIVolcadoDatos ven = new GUIVolcadoDatos();
                ven.Show();
            }
            else
            {
                MessageBox.Show("¡Tiene que configurar primero el archivo donde trabajara la aplicación!  \n\nVaya a la sección de configuraciones y configure el path de la aplicación.");
            }
        }
    }
}
