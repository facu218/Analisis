using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.SistEcuaciones
{
    public partial class frmSistEc : Form
    {
        public frmSistEc()
        {
            InitializeComponent();
        }

        private void frmSistEc_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            matriz.ColumnCount.Equals(Convert.ToInt32(textBox1.Text));
            matriz.RowCount.Equals(Convert.ToInt32(textBox1.Text));
        }
    }
}
