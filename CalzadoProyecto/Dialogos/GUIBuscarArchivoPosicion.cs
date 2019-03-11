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
    public partial class GUIBuscarArchivoPosicion : Form
    {
        public GUIBuscarArchivoPosicion()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Servicios.buscarEnAchivoPorPosicion(openFileDialog1.FileName, Decimal.ToInt32(numero.Value));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();

            try
            {
                String ruta = openFileDialog1.FileName;
                Servicios.leerCalzado(ruta);
            }
            catch (MensajeExepcion ef)
            {
                MessageBox.Show(ef.darExepcion());
            }
        }
    }
}
