﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.AjusteCurvas
{
    public class Gauss
    {
        public double[] GaussJordan(double[,] matriz, int variables)
        {
            double[] final = new double[variables];
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
                final[i] = (matriz[i, variables]);
            }
            return final;
        }
    }
}
