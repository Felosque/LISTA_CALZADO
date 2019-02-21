using CalzadoProyecto.Dialogos;
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

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIinsertarCalzado ven = new GUIinsertarCalzado();
            ven.Show();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

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
    }
}
