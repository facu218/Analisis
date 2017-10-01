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


        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            dgvResultado.ColumnCount = n;
            dgvResultado.RowCount = 1;
            double[,] Matriz = new double[n, n + 1];                             
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Matriz[j, i] = Convert.ToDouble(dgvGrilla[i, j].Value);
                }
            }
            //
            string[] temp = new string[n];
            var a = new Metodos();
            temp = a.GaussJordan(Matriz, n);
            for (int i = 0; i < n; i++)          //ERROR CON EL INDICE. Con el Checkpoint da valores correctos pero sigue sin andar.
            {                                    //#WTF #NoHayFormaDeErrarle #Help
                dgvResultado[i, 0].Value = temp[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //
            int n = Convert.ToInt32(textBox1.Text);
            dgvResultado.ColumnCount = n+1;
            dgvResultado.RowCount = 1;
            double[,] Matriz = new double[n, n + 1];                            
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Matriz[j, i] = Convert.ToDouble(dgvGrilla[i, j].Value);
                }
            }
            //
            string[] temp = new string[n];
            var a = new Metodos();
            a.ITER = Convert.ToInt16(txtIter.Text);
            a.TOLE = Convert.ToDouble(txtTole.Text);
            temp = a.GaussSeidel(Matriz);
            for (int i = 0; i < n+1; i++)          //ERROR CON EL INDICE. Con el Checkpoint da valores correctos pero sigue sin andar.
            {                                    //#WTF #NoHayFormaDeErrarle #Help
                dgvResultado[i, 0].Value = temp[i];
            }
        }

        private void dgvGrilla_KeyPress(object sender, KeyPressEventArgs e) //Permite solo ingreso de numeros.
        {
            if (e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar)) //Ingreso numeros, comas y retroceso.
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dgvGrilla_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;
            if (txt != null)
            {
                txt.KeyPress -= new KeyPressEventHandler(dgvGrilla_KeyPress);
                txt.KeyPress += new KeyPressEventHandler(dgvGrilla_KeyPress);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}
