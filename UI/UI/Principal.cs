using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.SistEcuaciones;
using UI.Regresion;

namespace UI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmRaiz frm = new FrmRaiz();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSistEc frm = new frmSistEc();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAjusteCurvas frm= new frmAjusteCurvas();
            frm.Show();
        }
    }
}
