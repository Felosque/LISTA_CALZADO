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
    public partial class GUIeliminarCalzado : Form
    {
        public GUIeliminarCalzado()
        {
            InitializeComponent();
            SelectorCalzado.SelectedIndex = 0;
        }

        private void SelectorCalzado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectorCalzado.SelectedIndex == 0)
            {
                txtPosicion.Visible = false;
                tbxPosicion.Visible = false;
            }
            else if (SelectorCalzado.SelectedIndex == 1)
            {
                txtPosicion.Visible = true;
                tbxPosicion.Visible = true;
            }
            else if (SelectorCalzado.SelectedIndex == 2)
            {
                txtPosicion.Visible = false;
                tbxPosicion.Visible = false;
            }
        }

        private void btVistaPrevia_Click(object sender, EventArgs e)
        {
            int id = 0;
            if(SelectorCalzado.SelectedIndex == 2){
                id = Servicios.darTamanoLista();
            }
            else{
                id = Decimal.ToInt32(tbxPosicion.Value);
            }

            if(Servicios.darCalzadoPorPosicion(id) == null)
            {
                MessageBox.Show("¡El calzado qué quieres visualizar no existe!");
            }else{
                GUIVistaPrevia ven = new GUIVistaPrevia(id);
                ven.ShowDialog();
            }
        }
    }
}
