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

namespace CalzadoProyecto.GUIArchivos
{
    public partial class GUIModificarArchivo : Form
    {

        private Calzado calzadoBuscado;
        private Calzado calzadoModificado;

        public GUIModificarArchivo()
        {
            InitializeComponent();
            SelectorTipoB.Visible = false;
            SelectorCalzadoB.SelectedIndex = 3;
        }

        private void GUIModificarArchivo_Load(object sender, EventArgs e)
        {

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

                tbxPrecioC.Value = (decimal)calzadoBuscado.darPrecio();
                tbxPrecioC.Visible = true;
                tbxTallaC.Value = calzadoBuscado.darTalla();
                tbxTallaC.Visible = true;
                tbxTipoC.Text = calzadoBuscado.darTipo();
                tbxTipoC.Visible = true;
                dteFechaC.Value = calzadoBuscado.darFechaDeCompra();
                dteFechaC.Visible = true;
                grpResultados.Visible = true;
                btnModificarCalzado.Visible = true;

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

        private void SelectorCalzadoB_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void btnModificarCalzado_Click(object sender, EventArgs e)
        {
            //Activamos los botones de las caracteristicas
            btnCancelar.Visible = true;
            btnConfirmar.Visible = true;
            btnModificarCalzado.Visible = false;
            tbxTipoC.Enabled = true;
            tbxTallaC.Enabled = true;
            tbxPrecioC.Enabled = true;
            dteFechaC.Enabled = true;

            //Desactivamos los botones de busquedas para evitar bugs
            activarBotonesDeBusqueda(false);
        }

        public void activarBotonesDeBusqueda(Boolean pEstado)
        {
            if (pEstado == true)
            {
                //Activamos los botones de busquedas
                tbxNumericoB.Enabled = true;
                dteFechaB.Enabled = true;
                SelectorCalzadoB.Enabled = true;
                SelectorTipoB.Enabled = true;
                btnBuscar.Enabled = true;
            }
            else
            {
                //Activamos los botones de busquedas
                tbxNumericoB.Enabled = false;
                dteFechaB.Enabled = false;
                SelectorCalzadoB.Enabled = false;
                SelectorTipoB.Enabled = false;
                btnBuscar.Enabled = false;
            }

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            btnModificarCalzado.Visible = true;
            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;
            tbxTipoC.Enabled = false;
            tbxTallaC.Enabled = false;
            tbxPrecioC.Enabled = false;
            dteFechaC.Enabled = false;
            btnBuscar_Click(sender, e);

            activarBotonesDeBusqueda(true);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            calzadoModificado = new Calzado(tbxTipoC.Text, Convert.ToInt32(tbxTallaC.Value), Convert.ToInt32(tbxPrecioC.Value), dteFechaC.Value, Constantes.ACTIVO);

            if (SelectorCalzadoB.SelectedIndex == 0) //Tipo
            {
                Servicios.modificarEnArchivoPorTipo(Servicios.darPath(), calzadoBuscado, calzadoModificado);
                calzadoModificado = null;
                MessageBox.Show("¡Se ha modificado correctamente el calzado seleccionado!");
            }
            else if (SelectorCalzadoB.SelectedIndex == 1) //Talla
            {

            }
            else if (SelectorCalzadoB.SelectedIndex == 2) //Precio
            {

            }
            else if (SelectorCalzadoB.SelectedIndex == 3) //Posicion
            {

            }
            else if (SelectorCalzadoB.SelectedIndex == 4) //Fecha
            {
                
            }

            btnModificarCalzado.Visible = true;
            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;
            tbxTipoC.Enabled = false;
            tbxTallaC.Enabled = false;
            tbxPrecioC.Enabled = false;
            dteFechaC.Enabled = false;
            btnBuscar_Click(sender, e);
            activarBotonesDeBusqueda(true);
            grpResultados.Visible = false;

        }
    }
}
