using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.SistEcuaciones;

namespace UI.AjusteCurvas
{
    public class MetodosAjuste
    {
        public string[] RegresionPolinomial(int puntos, double[] xi, double[]yi)
        {
            string[] final;
            double[] rdo = null;
            double CoeCo = 0;
            int n = 2;
            while (CoeCo < 80)    //Mientras el coeficiente sea menor que 80, vuelvue a resolver aumentando la potencia.
            {
                n = n + 1;     //Incrementa la potencia.
                double[,] matriz = new double[n, n + 1];  //armando la matriz
                double x;
                double y=0;
                for (int k=0; k<puntos; k++)
                {
                    y = y + yi[k];      //Sumatoria de Yi
                }
                for (int i=0; i<n; i++)
                {
                    for (int j=0; j<=n; j++) //empieza a recorrerla matriz de nxn+1 elementos, es decir grado n-1.
                    {
                        if (i == 0 && j == 0) //Pregunta si es el primero.
                        {
                            matriz[0, 0] = puntos; //El primer valor es el unico diferente.
                        }
                        else                    //No es el primero, sigue operando normalmente.
                        {
                            double valf=0;
                            for (int k=0; k<puntos; k++)
                            {
                                if (j < n) //Pregunta si el valor no es el ultimo de cada fila.
                                {
                                    x = Math.Pow(xi[k], i + j);
                                    valf = x;                   //Calcula el valor de esa pos.
                                }
                                else
                                {
                                    x = Math.Pow(xi[k], i);    // Calcula el valor de la ultima pos de cada fila.
                                    valf = y * x;
                                }
                            }
                            matriz[i, j] = valf;   //Arma la matriz con los valores.
                        }
                    } 
                }
                var a = new Gauss();      
                rdo = a.GaussJordan(matriz, n);   //Resuelve la matriz con el metodo Gauss-Jordan.
                double recP = y / puntos;         //Recta promedio entre los puntos
                double sr = 0, st = 0;            
                double sri=0;
                double xres = 0;
                for (int k=0; k<puntos; k++)
                {
                    for (int i=1; i<n; i++)
                    {
                        xres = xres -rdo[i] * xi[k];
                    }
                    sri = sri + Math.Pow(yi[k] - n - xres, 2);  //Valor de la funcion en ese punto (xi).
                    st = st + Math.Abs(yi[k] - recP);       //Dif de los puntos con la recta promedio.
                    sr = sr + Math.Abs(yi[k] - sri);        //Dif de los puntos con la funcion calculada.
                }
                CoeCo= Math.Sqrt((st - sr) / st) * 100;   //Coeficiente de correlacion.
            }
            final = new string[n];
            for (int i=0; i<n; i++)
            {
                final[i] = Convert.ToString(rdo[i]);
            }
            return final;
        }

        public string Lagrange (double[]xi, double[] yi, int valorinterp)
        {
            int n = xi.Length;
            double soluc = 0;
            for (int j=0; j<=n; j++)
            {
                double num = 1;
                double den = 1;
                for (int i=0; i<=n; i++)
                {
                    if (i != j)
                    {
                        num = num * (valorinterp - xi[i]);
                        den = den * (xi[j] - xi[i]);
                    }
                }
                soluc += yi[j] * (num / den);
            }
            return "La imagen a interpolar en el valor X= " + valorinterp + " es Y= " + Convert.ToString(soluc);
        }
    }
}
