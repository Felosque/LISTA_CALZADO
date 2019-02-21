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
        }
    }
}
