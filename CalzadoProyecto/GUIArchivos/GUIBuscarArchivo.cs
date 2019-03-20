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

namespace CalzadoProyecto.Dialogos
{
    public partial class GUIBuscarArchivo : Form
    {

        private Calzado calzadoBuscado;

        public GUIBuscarArchivo()
        {
            InitializeComponent();
            SelectorTipoB.Visible = false;
            SelectorCalzadoB.SelectedIndex = 3;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectorCalzadoB.SelectedIndex == 0) //Tipo
                {
                    calzadoBuscado = Servicios.buscarEnAchivoPorTipo(Servicios.darPath(), SelectorTipoB.Text);
                }
                else if (SelectorCalzadoB.SelectedIndex == 1) //Talla
                {
                    calzadoBuscado = Servicios.buscarEnAchivoPorTalla(Servicios.darPath(), decimal.ToInt32(tbxNumericoB.Value));
                }
                else if (SelectorCalzadoB.SelectedIndex == 2) //Precio
                {
                    calzadoBuscado = Servicios.buscarEnAchivoPorPrecio(Servicios.darPath(), decimal.ToDouble(tbxNumericoB.Value));
                }
                else if (SelectorCalzadoB.SelectedIndex == 3) //Posicion
                {
                    calzadoBuscado = Servicios.buscarEnAchivoPorPosicion(Servicios.darPath(), decimal.ToInt32(tbxNumericoB.Value));
                }
                else if (SelectorCalzadoB.SelectedIndex == 4) //Fecha
                {
                    calzadoBuscado = Servicios.buscarEnAchivoPorFecha(Servicios.darPath(), dteFechaB.Value);
                }
                else if (SelectorCalzadoB.SelectedIndex == 5) //Id
                {
                    calzadoBuscado = Servicios.buscarEnAchivoPorId(Servicios.darPath(), decimal.ToInt32(tbxNumericoB.Value));
                }

                tbxPrecioC.Value = (decimal)calzadoBuscado.darPrecio();
                tbxIdC.Value = (decimal)calzadoBuscado.darId();
                tbxTallaC.Value = calzadoBuscado.darTalla();
                tbxTipoC.Items.Add(calzadoBuscado.darTipo());
                tbxTipoC.Text = calzadoBuscado.darTipo();
                dteFechaC.Value = calzadoBuscado.darFechaDeCompra();
                grpResultados.Visible = true;

            }
            catch (MensajeExepcion pr)
            {
                MessageBox.Show(pr.darExepcion());
                grpResultados.Visible = false;
            }
            catch (FechaExeption pi)
            {
                MessageBox.Show(pi.darExepcion());
                grpResultados.Visible = false;
            }
        }

        private void SelectorCalzadoB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectorCalzadoB.SelectedIndex == 0) //Tipo
            {
                tbxTexto.Text = "Tipo:";
                dteFechaB.Visible = false;
                tbxNumericoB.Visible = false;
                SelectorTipoB.Visible = true;
            }
            else if (SelectorCalzadoB.SelectedIndex == 1) //Talla
            {
                tbxNumericoB.Maximum = 50;
                tbxNumericoB.Minimum = 20;
                tbxNumericoB.Value = 20;
                tbxNumericoB.Increment = 1;
                tbxTexto.Text = "Talla:";
                dteFechaB.Visible = false;
                SelectorTipoB.Visible = false;
                tbxNumericoB.Visible = true;
            }
            else if (SelectorCalzadoB.SelectedIndex == 2) //Precio
            {
                tbxNumericoB.Maximum = 1000000000;
                tbxNumericoB.Minimum = 1;
                tbxNumericoB.Value = 1;
                tbxNumericoB.Increment = 1000;
                tbxTexto.Text = "Precio:";
                dteFechaB.Visible = false;
                SelectorTipoB.Visible = false;
                tbxNumericoB.Visible = true;
            }
            else if (SelectorCalzadoB.SelectedIndex == 3) //Posicion
            {
                tbxNumericoB.Maximum = 1000000000;
                tbxNumericoB.Minimum = 0;
                tbxNumericoB.Value = 0;
                tbxNumericoB.Increment = 1;
                tbxTexto.Text = "Posición:";
                dteFechaB.Visible = false;
                SelectorTipoB.Visible = false;
                tbxNumericoB.Visible = true;
            }
            else if (SelectorCalzadoB.SelectedIndex == 4) //Fecha
            {
                tbxTexto.Text = "Fecha:";
                SelectorTipoB.Visible = false;
                tbxNumericoB.Visible = false;
                dteFechaB.Visible = true;
            }
        }

        private void GUIBuscarArchivo_Load(object sender, EventArgs e)
        {

        }
    }
}
