using CalzadoProyecto.servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalzadoProyecto.Dialogos
{
    public partial class GUIVistaPrevia : Form
    {
        private Calzado calzado;
        private int num;
        public GUIVistaPrevia(int pNum)
        {
            InitializeComponent();
            calzado = Servicios.buscarCalzadoPorPosicion(pNum);
            num = pNum;
        }

        private void GUIVistaPrevia_Load(object sender, EventArgs e)
        {
            tbxFecha.Text = calzado.darFechaDeCompra().ToString();
            tbxPosicion.Text = num.ToString();
            tbxPrecio.Text = calzado.darPrecio().ToString();
            tbxTalla.Text = calzado.darTalla().ToString();
            tbxTipo.Text = calzado.darTipo().ToString();

            if (calzado.darTipo().Equals("Botas"))
            {
                pbxImg.Image = Properties.Resources.ls_Botas;
                pbxImg.Refresh();
            }
            else if(calzado.darTipo().Equals("Chanclas"))
            {
                pbxImg.Image = Properties.Resources.ls_Chancla;
                pbxImg.Refresh();
            }
            else if (calzado.darTipo().Equals("Tacones"))
            {
                pbxImg.Image = Properties.Resources.ls_Tacon;
                pbxImg.Refresh();
            }
            else if (calzado.darTipo().Equals("Deportivos"))
            {
                pbxImg.Image = Properties.Resources.ls_Deportivos;
                pbxImg.Refresh();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
