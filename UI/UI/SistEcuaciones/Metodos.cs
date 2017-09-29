﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.SistEcuaciones
{
    class Metodos
    {
        public double[] GaussJordan (double[,] matriz, int variables)
        {
            double[] final = new double[variables];
            int Fil = 0;
            int Col = 0;
            int ant,pos;
            double Coe1;
            Boolean flgVarCero = false;
            Boolean flgSalida = false;
            // VERIFICAR QUE EL COEFICIENTE NO SEA CERO, SI ES SE REEMPLAZA POR OTRA FILA.
            for (int j = 0; j < variables; j++)
            {
                Col = j;
                Fil = Col;
                ant = Fil; //Guarda la fila en la que esta.
                pos = Fil;
                while ( flgSalida ==false)
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
                Coe1 = matriz[Fil, Col];
                for (int i=0; i<=variables; i++)                        // ARMA E1n
                {
                    matriz[Fil, i] = matriz[Fil, i] / Coe1; 
                }
                double[] temp = new double[variables];              // Array temporal para guardar AxE1n 
                for (int k=0; k<variables; k++)          //Recorre filas.
                {
                    for (int i=0; i<variables; i++)      //Recorre columnas.
                    {
                        temp[i] = matriz[k, Col] * matriz[Fil, i];           // ARMA ARRAy                      
                    }
                    for (int i = 0; i < variables; i++)  //Recorre columnas.
                    {
                        if (k > Fil | k < Fil)
                        {
                            matriz[k, Col] = matriz[k, i] - temp[i];       // Realiza la op. con las filas ant y sig. usando el array
                        }
                    }
                }   //QUIZA PUEDA HACERSE LO ANTERIOR EN UN SOLO FOR QUE RECORRA LAS COLUMNAS. PROBAR.   
            }   
            for (int i=0; i < variables; i++)
            {
                
                final[i] = matriz[i, variables-1];
            }
            return final;
        }
    }
}
