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
    public partial class GUIConfiguracion : Form
    {
        public GUIConfiguracion()
        {
            InitializeComponent();
        }

        private void GUIConfiguracion_Load(object sender, EventArgs e)
        {
            if (Servicios.darPath() == "")
            {
                txbRuta.Text = "¡No hay ruta configurada!";
            }else
            {
                txbRuta.Text = Servicios.darPath();
            }
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
    }
}
