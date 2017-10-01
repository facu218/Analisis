using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.SistEcuaciones
{
    public class Metodos
    {
        public double TOLE { get; set; }
        public int ITER { get; set; }
        
        public Metodos()
        {
            TOLE = 0.0001;
            ITER = 100;
        }

        public double[,] DespejarEcuacion(double[,] matriz)
        {
            double[,] matrizAux = matriz;
            int CanF = matrizAux.GetLength(0);
            int CanC = matrizAux.GetLength(1);
            double[,] Resultado = new double[CanF, CanC+1];//Igual que la matriz, pero agrega una columan al final que guarda el coeficiente de la diagonal principal(divisor)
            //double[] Divisores = new double[CanF];

            for (int f = 0; f < CanF; f++)//Recorrer filas
            {
                for (int c = 0; c < CanC-1; c++)//Recorrer las columnas. No llega hasta el resultado de la ecuacion
                {
                    if (f == c)//Diagonal principal
                    {
                        Resultado[f,CanC] = matrizAux[f, c];//Guarda en la ultima columna
                        matrizAux[f, c] = 0;
                    }
                    else
                    {
                        matrizAux[f, c] = matrizAux[f, c] * (-1);
                    }
                }
                for (int c = 0; c < CanC; c++)
                {
                    Resultado[f, c] = matrizAux[f, c];
                }                   
            }

            return Resultado;
        }

        public bool ErrorR (double[]s,double[]a)
        {
            bool ResError = true;
            for (int i = 0; i < s.Length-1; i++)
            {
                if (Math.Abs(Math.Abs(s[i]) - Math.Abs(a[i])) > TOLE)
                {
                    ResError = false;
                }
            }
            return ResError;
        }

        public string[] GaussJordan(double[,] matriz, int variables)
        {
            string[] final = new string[variables];
            int Fil = 0;
            int Col = 0;
            int ant, pos;
            double CoeP;
            Boolean flgVarCero = false;
            Boolean flgSalida = false;
            // VERIFICAR QUE EL COEFICIENTE NO SEA CERO, SI ES SE REEMPLAZA POR OTRA FILA.
            for (Col = 0; Col < variables; Col++)
            {
                Fil = Col;
                ant = Fil; //Guarda la fila en la que esta.
                pos = Fil;
                while (flgSalida == false)
                {
                    if (matriz[pos, Col] == 0)  //Si es 0 aumenta la fila.
                    {
                        pos++;
                        flgVarCero = true;
                    }
                    else
                    {
                        if (flgVarCero == true)             //Intercambio de filas.
                        {
                            for (int i = Col; i <= variables; i++)
                            {
                                double aux;
                                aux = matriz[pos, i];
                                matriz[pos, i] = matriz[ant, i];
                                matriz[ant, i] = aux;
                            }
                        }
                        flgVarCero = false;
                        flgSalida = true;
                    }
                }// comprobacion si llega al final y no hay coef dist de cero. NUNCA VA A PASAR NO HACE FALTA
                // ACA VA LA NORMALIZACION.
                CoeP = matriz[Fil, Col];
                for (int i = 0; i <= variables; i++)                    //Recorre columnas.    
                {
                    matriz[Fil, i] = matriz[Fil, i] / CoeP;         // ARMA E1n.
                }
                double[] temp = new double[variables + 1];              // Array temporal para guardar AxE1n 
                for (int k = 0; k < variables; k++)          //Recorre filas.
                {
                    double Valor = matriz[k, Col];
                    for (int i = 0; i <= variables; i++)  //Recorre columnas.
                    {
                        if (k != Fil) // Saltea la fila con la que esta trabajando.
                        {
                            temp[i] = Valor * matriz[Fil, i];
                            matriz[k, i] = matriz[k, i] - temp[i];       // Realiza la op. con las filas ant y sig. usando el array
                        }
                    }
                }   //QUIZA PUEDA HACERSE LO ANTERIOR EN UN SOLO FOR QUE RECORRA LAS COLUMNAS. PROBAR.   
            }
            for (int i = 0; i < variables; i++)
            {
                final[i] = "X" + i + " = " + Convert.ToString(matriz[i, variables]);
            }
            return final;
        }

        public string[] GaussSeidel(double[,] matriz)
        {
            int CanF = matriz.GetLength(0);//Cantidad de ecuaciones
            int CanC = matriz.GetLength(1);
            int UltimaC = matriz.GetLength(1) - 1;
            string[] final = new string[CanF+1];

            //Hacer el pivoteo parcial
            
            //Despejar la ecuacion
            double[,] Ecuaciones = DespejarEcuacion(matriz);

            //Solucion de arranque
            double[] Soluciones = new double[CanF];
            double[] Anteriores = new double[CanF];
            bool flgSalida = false;
            int Contador = 0;

            do//Hacer hasta que pase las iteraciones o el error relativo sea menor a TOLE
            {
                for (int f = 0; f < CanF; f++)
                {
                    Anteriores[f] = Soluciones[f];
                    double temp = 0;
                    //double SolucionIndividual = Ecuaciones[f, CanC - 1];

                    for (int c = 0; c < CanC - 1; c++)//Recorro columnas, excepto ultima y anteultima
                    {
                        temp += Ecuaciones[f, c] * Soluciones[c];
                    }

                    temp += Ecuaciones[f,CanC-1];
                    temp= temp / Ecuaciones[f, CanC];
                    Soluciones[f] = temp;
                }
                Contador++;

                //calcular la salida
                if (ErrorR(Soluciones, Anteriores) == true || Contador > ITER)
                {
                    flgSalida = true;
                }
            }
            while (flgSalida == false);

            for (int i = 0; i < CanF; i++)
            {
                final[i] = "X" + i+1 + " = " + Convert.ToString(Soluciones[i]);
            }
            final[CanF] = "Iteraciones: " + Convert.ToString(Contador);
            return final;


        }
    }
}
