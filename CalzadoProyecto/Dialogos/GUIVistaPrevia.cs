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

namespace CalzadoProyecto.Dialogos
{
    public partial class GUIVistaPrevia : Form
    {
        public GUIVistaPrevia(int pNum)
        {
            InitializeComponent();

            Calzado calzado = Servicios.darCalzadoPorPosicion(pNum);
            tbxFecha.Text = calzado.darFechaDeCompra().ToString();
            tbxPosicion.Text = pNum.ToString();
            tbxPrecio.Text = calzado.darPrecio().ToString();
            tbxTalla.Text = calzado.darTalla().ToString();
            tbxTipo.Text = calzado.darTipo().ToString();

        }

        private void GUIVistaPrevia_Load(object sender, EventArgs e)
        {

        }
    }
}
