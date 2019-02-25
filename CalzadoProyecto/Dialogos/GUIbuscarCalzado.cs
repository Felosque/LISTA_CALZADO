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
    public partial class GUIbuscarCalzado : Form
    {
        private Calzado calzadoBuscado;
        private Calzado calzadoModificado;

        public GUIbuscarCalzado()
        {
            InitializeComponent();
            SelectorCalzadoB.SelectedIndex = 0;
            calzadoBuscado = null;
            calzadoModificado = null;
        }

        private void GUIbuscarCalzado_Load(object sender, EventArgs e)
        {
            
        }

        /*tipo
        talla
        precio
        posición
        fecha
         */
        private void SelectorCalzado_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectorCalzadoB.SelectedIndex == 0) //Tipo
                {
                    calzadoBuscado = Servicios.buscarCalzadoPorTipo(SelectorTipoB.Text);
                }
                else if (SelectorCalzadoB.SelectedIndex == 1) //Talla
                {
                    calzadoBuscado = Servicios.buscarCalzadoPorTalla(decimal.ToInt32(tbxNumericoB.Value));
                }
                else if (SelectorCalzadoB.SelectedIndex == 2) //Precio
                {
                    calzadoBuscado = Servicios.buscarCalzadoPorPrecio(decimal.ToInt32(tbxNumericoB.Value));
                }
                else if (SelectorCalzadoB.SelectedIndex == 3) //Posicion
                {
                    calzadoBuscado = Servicios.buscarCalzadoPorPosicion(decimal.ToInt32(tbxNumericoB.Value));
                }
                else if (SelectorCalzadoB.SelectedIndex == 4) //Fecha
                {
                    calzadoBuscado = Servicios.buscarCalzadoPorFecha(dteFechaB.Value);
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

            }catch(MensajeExepcion pr){
                MessageBox.Show(pr.darExepcion());
                grpResultados.Visible = false;
            }
            catch (FechaExeption pi)
            {
                MessageBox.Show(pi.darExepcion());
                grpResultados.Visible = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnConfirmar.Visible = false;
            btnCancelar.Visible = false;
            btnModificarCalzado.Visible = true;
            tbxTipoC.Enabled = false;
            tbxTallaC.Enabled = false;
            tbxPrecioC.Enabled = false;
            dteFechaC.Enabled = false;
            btnBuscar_Click(sender, e);

            activarBotonesDeBusqueda(true);
        }

        private void btnModificarCalzado_Click(object sender, EventArgs e)
        {
            //Desactivamos los botones de las caracteristicas
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                String tipo = tbxTipoC.Text;
                double precio = (double)tbxPrecioC.Value;
                int talla = (int)tbxTallaC.Value;
                DateTime fecha = dteFechaC.Value;
                calzadoModificado = new Calzado(tipo, talla, precio, fecha);
                MessageBox.Show("¡Se ha modificado el calzado correctamente!\n\n"+
                                "---------ANTERIOR CALZADO\n\nTipo: "+calzadoBuscado.darTipo()+"\nPrecio: "+calzadoBuscado.darPrecio()+"\nTalla: "+calzadoBuscado.darTalla()+"\nFecha: "+calzadoBuscado.darFechaDeCompra()+"\n\n"+
                                "---------ACTUAL CALZADO\n\nTipo: " + calzadoModificado.darTipo() + "\nPrecio: " + calzadoModificado.darPrecio() + "\nTalla: " + calzadoModificado.darTalla() + "\nFecha: " + calzadoModificado.darFechaDeCompra());
                Servicios.modificarCalzados(calzadoBuscado, calzadoModificado);
                //Activamos los botones de busquedas
                activarBotonesDeBusqueda(true);
                btnConfirmar.Visible = false;
                btnCancelar.Visible = false;
                btnModificarCalzado.Visible = true;
                tbxTipoC.Enabled = false;
                tbxTallaC.Enabled = false;
                tbxPrecioC.Enabled = false;
                dteFechaC.Enabled = false;
            }
            catch (MensajeExepcion pr)
            {
                MessageBox.Show(pr.darExepcion());
            }
            catch (FechaExeption pi)
            {
                MessageBox.Show(pi.darExepcion());
            }
        }

        public void activarBotonesDeBusqueda(Boolean pEstado)
        {
            if(pEstado == true)
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
    }
}
