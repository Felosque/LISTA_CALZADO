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

namespace CalzadoProyecto.GUIArchivos
{
    public partial class GUIVolcadoDatos : Form
    {
        public GUIVolcadoDatos()
        {
            InitializeComponent();
            if (Servicios.darPath() == "")
            {
                txbRuta.Text = "¡No hay ruta configurada!";
            }
            else
            {
                txbRuta.Text = Servicios.darPath();
            }
            tbxRutaV.Text = "¡No hay una ruta configurada!";
        }

        private void btnCRuta_Click(object sender, EventArgs e)
        {
            dialogoPath.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            dialogoPath.FilterIndex = 1;
            dialogoPath.Multiselect = false;

            if (dialogoPath.ShowDialog() == DialogResult.OK)
            {
                Servicios.cambiarPath(dialogoPath.FileName);
                txbRuta.Text = dialogoPath.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dialogoPath.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            dialogoPath.FilterIndex = 1;
            dialogoPath.Multiselect = false;

            if (dialogoPath.ShowDialog() == DialogResult.OK)
            {
                tbxRutaV.Text = dialogoPath.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Servicios.volcarDatos(Servicios.darPath(), tbxRutaV.Text);
            MessageBox.Show("¡Se han volcado todos los datos correctamente!");
        }

        private void GUIVolcadoDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
