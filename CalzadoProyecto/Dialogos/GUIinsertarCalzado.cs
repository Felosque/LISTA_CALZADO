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
            }
            else if (SelectorCalzado.SelectedIndex == 1)
            {
                txtPosicion.Visible = true;
                tbxPosicion.Visible = true;
            }
            else if(SelectorCalzado.SelectedIndex == 2)
            {
                txtPosicion.Visible = false;
                tbxPosicion.Visible = false;
            }
        }

        
    }
}
