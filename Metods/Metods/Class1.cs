﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods
{
    class Program
    {
        static void Main(string[] args)
        {
            var RaizPrueba = new ResultadoRaiz();
            Console.WriteLine(RaizPrueba.Raiz(3, 8));
            Console.ReadKey();
        }
    }

    public class ResultadoRaiz
    {        
        public double Raiz (double xi, double xd)
        {
            var funcion = new Funcion();
            Boolean flagSalida = false;
            double raizFinal =0;
            int c=0;
            double Tole = 0.0001;
            double xant = 0;
            int Ite = 100;
            while (flagSalida == false)
            {
                if (funcion.Function(xi) * funcion.Function(xd) == 0)
                {
                    if (funcion.Function(xi) == 0)
                    {
                        raizFinal = xi;
                        flagSalida = true;
                    }
                    else
                    {
                        raizFinal = xd;
                        flagSalida = true;
                    }
                }
                else if (funcion.Function(xi) * funcion.Function(xd) > 0)
                {
                    //VOlver a ingresar xi xd
                }
                else //menor a cero
                {
                    double xr = (xi + xd) / 2;
                    double error = Math.Abs((xr - xant) / xr);
                    c++;

                    if (funcion.Function(xr)< Tole  || error< Tole|| c>= Ite )
                    {
                        raizFinal = xr;
                        flagSalida = true;
                    }
                    else if (funcion.Function(xi)*funcion.Function(xr)>0)
                    {
                        xi = xr;
                    }
                    else
                    {
                        xd = xr;
                    }
                    xant = xr;
                }

            }
            return raizFinal;
        }
    }
}
