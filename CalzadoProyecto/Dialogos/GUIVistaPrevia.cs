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

            if (tbxTipo.Equals("Botas"))
            {
                pbxImg.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Resources//logo2.png"));
            }
            else if(tbxTipo.Equals("Chanclas"))
            {
                pbxImg.Image = Image.FromFile("ls-Chancla.jpeg");
            }
            else if (tbxTipo.Equals("Tacones"))
            {
                pbxImg.Image = Image.FromFile("ls-Tacon.jpeg");
            }
            else if (tbxTipo.Equals("Deportivos"))
            {
                pbxImg.Image = Image.FromFile("logo2.png");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
