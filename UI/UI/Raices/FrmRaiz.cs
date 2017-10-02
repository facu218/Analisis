//using org.mariuszgromada.math.mxparser;
using Metods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmRaiz : Form
    {
        public FrmRaiz()
        {
            InitializeComponent();
        }

        System.Drawing.Pen mylapiz1 = new System.Drawing.Pen(System.Drawing.Color.Black);
        System.Drawing.Pen mylapiz2 = new System.Drawing.Pen(System.Drawing.Color.Red);

        Boolean flgBis, flgReg, flgTan, flgSec = false;
        private void biseccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flgBis = true;
            lblPrincipal.Text = "Ingrese dos valores para biseccion:";
            txtValor2.Visible = true;
            pnlRaiz.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = new ResultadoRaiz();
            //double xi = Convert.ToDouble(txtValor1.Text);
            //double xd = Convert.ToDouble(txtValor2.Text);
            string f = txtFunc.Text;
            pnlRaiz.Visible = false;
            int ite = Convert.ToInt16(txtIte.Text);
            double tole = Convert.ToDouble(txtTole.Text);
            if (flgBis== true)
            {
                double xi = Convert.ToDouble(txtValor1.Text);
                double xd = Convert.ToDouble(txtValor2.Text);
                txtResultado.Text = a.Biseccion(xi, xd, ite, tole,f);
            }else if (flgTan == true)
            {
                double xi = Convert.ToDouble(txtValor1.Text);
                txtResultado.Text = a.Tangente(xi, ite, tole,f);
            }else if(flgReg == true)
            {
                double xi = Convert.ToDouble(txtValor1.Text);
                double xd = Convert.ToDouble(txtValor2.Text);
                txtResultado.Text = a.ReglaFalsa(xi,xd, ite, tole,f);
            }else if (flgSec == true)
            {
                double x0 = Convert.ToDouble(txtValor1.Text);
                double x1 = Convert.ToDouble(txtValor2.Text);
                txtResultado.Text = a.Secante(x0, x1, ite, tole,f);
            }
            flgBis = false;
            flgTan = false;
            flgReg = false;
        }

        private void picBox_Paint(object sender, PaintEventArgs e)
        {
            int xcentro = picBox.Width / 2; // centro de x
            int ycentro = picBox.Height / 2;// centro de y
            e.Graphics.TranslateTransform(xcentro, ycentro);
            e.Graphics.ScaleTransform(1, -1);
            e.Graphics.DrawLine(mylapiz1, xcentro * -1, 0, xcentro * 2,0); // eje x
            e.Graphics.DrawLine(mylapiz1, 0, ycentro, 0, ycentro * -1); // eje y

        }
        private void Graficar()
        {
            System.Drawing.Graphics Dibujo = this.picBox.CreateGraphics();
            double[] valores = new double[20000];
            double puntoX1 = 0, puntoY1 = 0, puntoX2 = 0, puntoY2 = 0;
            int con = 0;
            int xcentro = picBox.Width / 2; // centro de x
            int ycentro = picBox.Height / 2;// centro de y
            var a = new Funcion();
            Dibujo.TranslateTransform(xcentro, ycentro);
            Dibujo.ScaleTransform(1, -1);

            for(int i=-xcentro; i<xcentro; i += 8)
            {
                Dibujo.DrawLine(mylapiz1, 5, i, -5, i);// eje y
                Dibujo.DrawLine(mylapiz1, i, 5, i, -5);// eje x
            }
            con = 0;
            for (double x = xcentro * -1; x < xcentro * 2; x += 0.1) 
            {
                valores[con] = a.Function(x);
                con = con + 1;
            }
            con = 1;
            for(double xx = xcentro * -1 + 0.1; xx < xcentro * 2; xx += 0.1)
            {
                puntoX1 = (xx - 0.1) * (picBox.Width / Convert.ToInt16(textBox2.Text) * 2);
                puntoY1 = valores[con - 1] * ycentro;
                puntoX2 = xx * (picBox.Width / Convert.ToInt16(textBox2.Text) * 2);
                puntoY2 = valores[con] * ycentro;

                Dibujo.DrawLine(mylapiz2, Convert.ToSingle(puntoX1), Convert.ToSingle(puntoY1), Convert.ToSingle(puntoX2), Convert.ToSingle(puntoY2));
                con = con + 1;                                                                                   
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graficar();
        }

        private void secanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flgSec = true;
            lblPrincipal.Text = "Ingrese dos valores para la Secante:";
            txtValor2.Visible = true;
            pnlRaiz.Visible = true;
        }

        private void reglaFalsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblPrincipal.Text = "Ingrese 2 valores para regla falsa:";
            txtValor2.Visible = true;
            pnlRaiz.Visible = true;
            flgReg = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            picBox.Image = null;
        }

        private void tangenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblPrincipal.Text = "Ingrese un valor para la tangente:";
            txtValor2.Visible = false;
            pnlRaiz.Visible = true;
            flgTan = true;
            
        }
    }
}
