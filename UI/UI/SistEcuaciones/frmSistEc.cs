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

        private void btnAceptar_Click(object sender, EventArgs e)               //Armando grilla.
        {
            int n = Convert.ToInt32(textBox1.Text);
            dgvGrilla.ColumnCount = n + 1;
            dgvResultado.ColumnCount = n;
            dgvResultado.RowCount = 1;
            dgvGrilla.RowCount = n;
        }

        private void btnCargarMatriz_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);                             //Deberia poderse cargar la matriz y usarla en 
            double[,] Matriz = new double[n, n + 1];                            //otros metodos. 
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
            for (int i = 0; i < n; i++)          //ERROR CON EL INDICE. Con el Checkpoint da valores correctos pero sigue sin andar.
            {                                    //#WTF #NoHayFormaDeErrarle #Help
                dgvResultado[0,i].Value = Convert.ToString(temp[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e) 
        {
                                                                 //Aca se pondria el codigo de arriba. Usando el Gauss-Jordan.
        }
    }
}
