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
            int n = Convert.ToInt32(textBox1.Text);
            dgvGrilla.ColumnCount = n + 1;
            dgvResultado.ColumnCount = n;
            dgvResultado.RowCount = 1;
            dgvGrilla.RowCount = n;
        }

        private void btnCargarMatriz_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            double[,] Matriz = new double[n, n + 1];
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Matriz[j, i] = Convert.ToDouble(dgvGrilla[i, j].Value);
                }
            }
            double[] temp = new double[n];
            var a = new Metodos();
            temp = a.GaussJordan(Matriz, n);
            for (int i = 0; i < n; i++)
            {
                dgvResultado[0,i].Value = Convert.ToString(temp[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
