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
    public partial class GUIInsertarArchivo : Form
    {
        public GUIInsertarArchivo()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            String tipo = tbxTipo.Text;
            int talla = Decimal.ToInt32(tbxTalla.Value);
            int precio = Decimal.ToInt32(tbxPrecio.Value);
            DateTime fecha = dteFecha.Value;

            try
            {
                Calzado adicionar = new Calzado(tipo, talla, precio, fecha, Constantes.ACTIVO);
                Servicios.adicionarCalzadoArchivo(adicionar);
                MessageBox.Show("¡Se adiciono el calzado correctamente en el archivo!\n" + "\nTipo: " + tipo + "\nTalla: " + talla + "\nPrecio: " + precio + "\nFecha: " + fecha);
                tbxPrecio.Value = 1;
                tbxTalla.Value = 20;
                tbxTipo.Text = "";
                tbxTipo.Focus();
            }
            catch (FechaExeption fe)
            {
                MessageBox.Show(fe.darExepcion());
            }
            catch (MensajeExepcion fa)
            {
                MessageBox.Show(fa.darExepcion());
            }
        }
    }
}
