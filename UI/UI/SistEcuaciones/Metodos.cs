using System;
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
                ant = Fil;
                pos = Fil;
                while ( flgSalida ==false)
                {
                    if (matriz[pos, Col] == 0)
                    {
                        pos++;
                        flgVarCero = true;
                    }
                    else
                    {
                        if (flgVarCero == true)
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
                }// comprobacion si llega al final y no hay coef dist de cero.
                // ACA VA LA NORMALIZACION.
                Coe1 = matriz[Fil, Col];
                for (int i=0; i<=variables; i++)                        // ARMA E1n
                {
                    matriz[Fil, i] = matriz[Fil, i] / Coe1; 
                }
                double[] temp = new double[variables];              // Array temporal para guardar AxE1n 
                for (int i=0; i<variables; i++)
                {
                    for (int k=0; k<variables; k++)
                    {
                        temp[i] = matriz[k, Col] * matriz[Fil, i];           // ARMA ARRAy
                        if (k > Fil | k<Fil)
                        {                               
                            matriz[k, Col] = matriz[k, i] - temp[i];       // Realiza la op. con las filas sig.
                        }                           
                    }
                }       
            }   
            for (int i=0; i < variables; i++)
            {
                
                final[i] = matriz[i, variables-1];
            }
            return final;
        }
    }
}
