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
            int inter = Convert.ToInt32(txtInter.Text);
            RadioButton radioBtn = (RadioButton)sender;
            var n = new MetodosArea();
            if (radioBtn.Checked == true)
            {
                switch (radioBtn.Name)
                {
                    case "rbTrapecio":
                        txtResultado.Text = Convert.ToString(n.Trapecio(f, a, b));
                        break;

                    case "rbTrapecioM":
                        txtResultado.Text = Convert.ToString(n.TrapecioMultiple(f, a, b, inter));
                        break;

                    case "rbSimpson13":
                        txtResultado.Text = Convert.ToString(n.Simpson13(f, a, b));
                        break;

                    case "rbSimpson13M":
                        txtResultado.Text = Convert.ToString(n.Simpson13_Multiple(f, a, b, inter));
                        break;

                    case "rbSimpson38":
                        txtResultado.Text = Convert.ToString(n.Simpson38(f, a, b));
                        break;
                }

            }
        }
    }
}
