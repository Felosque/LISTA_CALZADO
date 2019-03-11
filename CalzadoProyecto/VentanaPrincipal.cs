using CalzadoProyecto.Dialogos;
using CalzadoProyecto.Exepciones;
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

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rutaGuardar.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            rutaGuardar.FilterIndex = 1;
            rutaGuardar.Multiselect = false;
            rutaGuardar.ShowDialog();

            try
            {
                String ruta = rutaGuardar.FileName;
                Servicios.guardarCalzados(ruta);
            }catch(MensajeExepcion ef)
            {
                MessageBox.Show(ef.darExepcion());
            }

        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rutaGuardar.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            rutaGuardar.FilterIndex = 1;
            rutaGuardar.Multiselect = false;
            rutaGuardar.ShowDialog();

            try
            {
                String ruta = rutaGuardar.FileName;
                Servicios.leerCalzado(ruta);
            }
            catch (MensajeExepcion ef)
            {
                MessageBox.Show(ef.darExepcion());
            }
        }

        private void buscarPorPosiciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIBuscarArchivoPosicion ven = new GUIBuscarArchivoPosicion();
            ven.Show();
        }
    }
}
