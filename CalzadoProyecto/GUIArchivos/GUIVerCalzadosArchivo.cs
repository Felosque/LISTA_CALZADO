using CalzadoProyecto.servicios;
using System;
using System.Collections;
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
    public partial class GUIVerCalzadosArchivo : Form
    {
        public GUIVerCalzadosArchivo()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarLista();
        }

        public void actualizarLista()
        {
            ArrayList calzados = Servicios.leerCalzadoArchivo(Servicios.darPath());
            IEnumerator e = calzados.GetEnumerator();
            dtaDatos.Rows.Clear();
            for (int i = 0; i < calzados.Count; i++)
            {
                e.MoveNext();
                Calzado ver = (Calzado) e.Current;
                dtaDatos.Rows.Add();
                dtaDatos.Rows[i].Cells[0].Value = i;
                dtaDatos.Rows[i].Cells[1].Value = ver.darTipo();
                dtaDatos.Rows[i].Cells[2].Value = ver.darTalla();
                dtaDatos.Rows[i].Cells[3].Value = ver.darPrecio();
                dtaDatos.Rows[i].Cells[4].Value = ver.darFechaDeCompra();
            }
        }
    }
}
