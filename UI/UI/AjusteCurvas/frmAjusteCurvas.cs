﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.AjusteCurvas;

namespace UI.Regresion
{
    public partial class frmAjusteCurvas : Form
    {
        public frmAjusteCurvas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            dgvPuntos.ColumnCount = 2;
            dgvPuntos.RowCount = n;            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            double XY=0, sx=0 ,sy=0, sx2 = 0;

            //Calculo de A1
            
            
            for (int i = 0; i < n; i++)
            {
                XY = XY + Convert.ToDouble(dgvPuntos[0, i].Value) * Convert.ToDouble(dgvPuntos[1, i].Value);
                sx = sx + Convert.ToDouble(dgvPuntos[0, i].Value);
                sy = sy + Convert.ToDouble(dgvPuntos[1, i].Value);
                sx2 = sx2 + (Convert.ToDouble(dgvPuntos[0, i].Value)) * (Convert.ToDouble(dgvPuntos[0, i].Value));
            }

            double A1 = ((n * XY) - (sx * sy)) / ((n * sx2) - (sx*sx));
            double A0 = (sy / n) - A1 * (sx / n);
            double recP = sy / n;
            double sr = 0, st = 0;
            for (int i=0; i<n; i++)
            {
                double xi = Convert.ToDouble(dgvPuntos[0, i].Value);
                double yi = Convert.ToDouble(dgvPuntos[1, i].Value);
                double sri = ((A1 * xi) + A0);
                //sr = sr + Math.Abs(Math.Pow(yi-sri,2));
                sr = sr + Math.Pow(yi - sri, 2);
                st = st + Math.Pow(Convert.ToDouble(dgvPuntos[1, i].Value) - recP,2);
            }
            double r = Math.Sqrt((st - sr) / st)*100;

            textBox2.Text = "Y = " + Math.Round(A1,4) + "x + (" + Math.Round(A0, 4) + ")";
            txtCoe.Text = r + "%";
        }

        private void btnPolinomial_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int xl = Convert.ToInt32(txtPot.Text);
            double[] xi = new double[n];
            double[] yi = new double[n];
            for (int i=0; i < n; i++)
            {
                xi[i] = Convert.ToDouble(dgvPuntos[0, i].Value);
                yi[i] = Convert.ToDouble(dgvPuntos[1, i].Value);
            }           
            var a = new MetodosAjuste();
            string j = a.Polinomial( xi, yi, xl);
            textBox2.Text = j;
            txtCoe.Text = Convert.ToString(Math.Round(a.Coeficiente,2))+ "%";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ninter = Convert.ToInt32(txtInter.Text);
            int n = Convert.ToInt32(textBox1.Text);
            double[] xi = new double[n];
            double[] yi = new double[n];
            for (int i = 0; i < n; i++)
            {
                xi[i] = Convert.ToDouble(dgvPuntos[0, i].Value);
                yi[i] = Convert.ToDouble(dgvPuntos[1, i].Value);
            }
            var a = new MetodosAjuste();
            string rdo = a.Lagrange(xi, yi, ninter);
            label4.Text = "Imagen de la interpolacion";
            textBox2.Text = rdo;
            lblCoe.Visible = false;
            txtCoe.Visible = false;
            txtPot.Visible = false;
            lblPot.Visible = false;
        }

        private void rdbLineal_CheckedChanged(object sender, EventArgs e)
        {
            txtPot.Enabled = false;
            txtInter.Enabled = false;

        }

        private void rdbPolinomial_CheckedChanged(object sender, EventArgs e)
        {
            txtPot.Enabled = true;
            txtInter.Enabled = false;
        }

        private void rdbLagrange_CheckedChanged(object sender, EventArgs e)
        {
            txtInter.Enabled = true;
            txtPot.Enabled = false;
        }

        private void txtInter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
