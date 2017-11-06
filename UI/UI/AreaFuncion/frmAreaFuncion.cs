using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.AreaFuncion
{
    public partial class frmAreaFuncion : Form
    {
        public frmAreaFuncion()
        {
            InitializeComponent();
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            string f = txtFunc.Text;
            double a = Convert.ToDouble(txtValA.Text);
            double b = Convert.ToDouble(txtValB.Text);
            int? inter = null;
            
            if (!string.IsNullOrEmpty(txtInter.Text))
            {
                inter = Convert.ToInt32(txtInter.Text);
            }
            
            var n = new MetodosArea();
            if (rbTrap.Checked)
            {
                txtResultado.Text = "El area por Trapecio es: " + Convert.ToString(n.Trapecio(f, a, b));
            }
            else if (rbTrapM.Checked)
            {
                txtResultado.Text = "El area por Trapecio multiple es: " + Convert.ToString(n.TrapecioMultiple(f, a, b, inter.Value));
            }
            else if (rbSimpson13.Checked)
            {
                txtResultado.Text = "El area por Simpson 1/3 es: " + Convert.ToString(n.Simpson13(f, a, b));

            }
            else if (rbSimpson13M.Checked)
            {
                txtResultado.Text = "El area por Simpson 1/3 multiple es: " + Convert.ToString(n.Simpson13_Multiple(f, a, b, inter.Value));

            }
            else
            {
                txtResultado.Text = "El area por Simpson 3/8 es: " + Convert.ToString(n.Simpson38(f, a, b));

            }
        }
    }
}
