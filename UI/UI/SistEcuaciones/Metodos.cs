using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.SistEcuaciones
{
    class Metodos
    {
        public string GaussJordan (double[,] matriz, int variables)
        {
            //int variables = matriz.Length - 1;
            int C = 0;
            int F = 0;
            int ant,pos;
            Boolean flgVarCero = false;
            double[,] temp = new double[1, variables];
            // VERIFICAR QUE EL COEFICIENTE NO SEA CERO, SI ES SE REEMPLAZA POR OTRA FILA.
            for (int k=0; k<variables; k++)
            {
                C = k;
                for (int j = 0; j < variables; j++)
                {
                    F = j;
                    ant = C;
                    pos = C;
                    while (pos <= variables)
                    {
                        if (matriz[pos, F] == 0)
                        {
                            ant = pos;
                            pos++;
                            flgVarCero = true;
                        }
                        else
                        {
                            if (flgVarCero == true)
                            {
                                for (var i = 0; i <= variables + 1; i++)
                                {
                                    double aux;
                                    aux = matriz[C, i];
                                    matriz[C, i] = matriz[ant, i];
                                    matriz[ant, i] = aux;
                                }
                            }
                            flgVarCero = false;

                        }
                    }// comprobacion si llega al final y no hay coef dist de cero.
                    // ACA VA LA NORMALIZACION.
                }
            }
            

            return null;
        }
    }
}
