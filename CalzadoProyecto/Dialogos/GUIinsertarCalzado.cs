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
    public partial class GUIinsertarCalzado : Form
    {
        public GUIinsertarCalzado()
        {
            InitializeComponent();
            SelectorCalzado.SelectedIndex = 0;
        }

        private void GUIinsertarCalzado_Load(object sender, EventArgs e)
        {

        }

        private void SelectorCalzado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectorCalzado.SelectedIndex == 0)
            {
                txtPosicion.Visible = false;
                tbxPosicion.Visible = false;
                tbxPosicion.Value = 0;
                msgError.Visible = false;
            }
            else if (SelectorCalzado.SelectedIndex == 1)
            {
                txtPosicion.Visible = true;
                tbxPosicion.Visible = true;
                msgError.Visible = true;
            }
            else if(SelectorCalzado.SelectedIndex == 2)
            {
                txtPosicion.Visible = false;
                tbxPosicion.Visible = false;
                msgError.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tipo = tbxTipo.Text;
            int talla = Decimal.ToInt32(tbxTalla.Value);
            int precio = Decimal.ToInt32(tbxPrecio.Value);
            DateTime fecha = dteFecha.Value;
            int posicion = Decimal.ToInt32(tbxPosicion.Value);

            try
            {
                Calzado adicionar = new Calzado(tipo, talla, precio, fecha);
                if (SelectorCalzado.SelectedIndex == 0)
                {
                    Servicios.adicionarCalzadoAlInicio(adicionar);
                }
                else if (SelectorCalzado.SelectedIndex == 1)
                {
                    Servicios.adicionarCalzadoEnMedio(adicionar, posicion);
                }
                else if (SelectorCalzado.SelectedIndex == 2)
                {
                    Servicios.adicionarCalzadoAlFinal(adicionar);
                }
                MessageBox.Show("¡Se adiciono el calzado correctamente!\n" + "\nTipo: " + tipo + "\nTalla: " + talla + "\nPrecio: " + precio + "\nFecha: " + fecha);
                tbxPosicion.Value = 0;
                tbxPrecio.Value = 1;
                tbxTalla.Value = 20;
                tbxTipo.Text = "";
                tbxTipo.Focus();
            }
            catch(FechaExeption fe)
            {
                MessageBox.Show(fe.darExepcion());
            }
            catch(MensajeExepcion fa)
            {
                MessageBox.Show(fa.darExepcion());
            } 
        }

        private void tbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbxTipo.SelectedIndex == 0)
            {
                pbxImg.Image = Properties.Resources.ls_Chancla;
                pbxImg.Refresh();
            }
            else if (tbxTipo.SelectedIndex == 1)
            {
                pbxImg.Image = Properties.Resources.ls_Botas;
                pbxImg.Refresh();
            }
            else if (tbxTipo.SelectedIndex == 2)
            {
                pbxImg.Image = Properties.Resources.ls_Tacon;
                pbxImg.Refresh();
            }
            else if (tbxTipo.SelectedIndex == 3)
            {
                pbxImg.Image = Properties.Resources.ls_Deportivos;
                pbxImg.Refresh();
            }
        }
    }
}
