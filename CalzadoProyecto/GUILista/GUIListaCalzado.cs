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
    public partial class GUIListaCalzado : Form
    {
        public GUIListaCalzado()
        {
            InitializeComponent();
        }

        private void GUIListaCalzado_Load(object sender, EventArgs e)
        {
            Servicios.verCalzados();
            actualizarLista();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarLista();
        }

        public void actualizarLista()
        {
            if (Servicios.darCabecera() != null)
            {
                dtaDatos.Rows.Clear();
                for (int i = 0; i < Servicios.darTamanoLista(); i++)
                {
                    dtaDatos.Rows.Add();
                    dtaDatos.Rows[i].Cells[0].Value = i;
                    dtaDatos.Rows[i].Cells[1].Value = Servicios.buscarCalzadoPorPosicion(i).darTipo();
                    dtaDatos.Rows[i].Cells[2].Value = Servicios.buscarCalzadoPorPosicion(i).darTalla();
                    dtaDatos.Rows[i].Cells[3].Value = Servicios.buscarCalzadoPorPosicion(i).darPrecio();
                    dtaDatos.Rows[i].Cells[4].Value = Servicios.buscarCalzadoPorPosicion(i).darFechaDeCompra();
                }
            }
            else
            {
                MessageBox.Show("¡La lista esta vacia!");
            }
        }

        private void dtaDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
