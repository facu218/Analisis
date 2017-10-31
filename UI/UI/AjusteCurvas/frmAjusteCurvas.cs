﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Regresion
{
    public partial class frmAjusteCurvas : Form
    {
        public frmAjusteCurvas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            dgvPuntos.ColumnCount = 2;
            dgvPuntos.RowCount = n;
            


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmAjusteCurvas_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int XY=0, sx=0 ,sy=0, sx2 = 0;

            //Calculo de A1
            
            
            for (int i = 0; i < n; i++)
            {
                XY = XY + Convert.ToInt32(dgvPuntos[0, i].Value) * Convert.ToInt32(dgvPuntos[1, i].Value);
                sx = sx + Convert.ToInt32(dgvPuntos[0, i].Value);
                sy = sy + Convert.ToInt32(dgvPuntos[1, i].Value);
                sx2 = sx2 + (Convert.ToInt32(dgvPuntos[0, i].Value)) * (Convert.ToInt32(dgvPuntos[0, i].Value));
            }

            double A1 = ((n * XY) - (sx * sy)) / ((n * sx2) - (sx*sx));
            double A0 = (sy / n) - A1 * (sx / n);
            double recP = sy / n;
            double sr = 0, st = 0;
            for (int i=0; i<n; i++)
            {
                int xi = Convert.ToInt32(dgvPuntos[0, i].Value);
                int yi = Convert.ToInt32(dgvPuntos[1, i].Value);
                double sri = ((A1 * xi) + A0);
                sr = sr + Math.Abs(Math.Pow(yi-sri,2));
                st = st + Math.Abs(Convert.ToInt32(dgvPuntos[1, i].Value) - recP);
            }
            double r = Math.Sqrt((st - sr) / st)*100;

            textBox2.Text = "Y = " + A1 + "X +" + A0;
            txtCoe.Text = "%" + r;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
