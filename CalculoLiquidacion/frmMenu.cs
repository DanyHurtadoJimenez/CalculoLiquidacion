using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CalculoLiquidacion
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void mnuCalcular_Click(object sender, EventArgs e)
        {
            frmCalculoLiquidacion formulario = new frmCalculoLiquidacion();
            formulario.Show(this);
        }
    }
}
