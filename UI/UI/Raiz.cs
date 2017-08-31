using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods
{
    public class ResultadoRaiz
    {        
        public string Biseccion (double xi, double xd, int ite, double toler)
        {
            var funcion = new Funcion();
            Boolean flagSalida = false, flgNoRaiz = false;
            double raizFinal =0;
            int c=0;
            double Tole = toler;
            double xant = 0;
            int Ite = ite;
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
                else if (funcion.Function(xi) * funcion.Function(xd) > 0) //Mayor a cero, ingresa nuevos valores.
                {
                    flgNoRaiz = true;
                    flagSalida = true;
                }
                else //menor a cero
                {
                    double xr = (xi + xd) / 2;
                    double error = Math.Abs((xr - xant) / xr);
                    c++;

                    if (Math.Abs(funcion.Function(xr))< Tole  || error< Tole|| c>= Ite )
                    {
                        raizFinal = xr;
                        flagSalida = true;
                    }
                    else if (funcion.Function(xi)*funcion.Function(xr)>0)
                    {
                        xi = xr;
                        xant = xr;
                    }
                    else
                    {
                        xd = xr;
                        xant = xr;
                    }
                }
            }
            if (flgNoRaiz == true)
            {
                return "No se encuentra ninguna raiz entre esos dos valores. Ingrese nuevos.";
            }else return "El resultado de la raiz entre la biseccion es " + raizFinal.ToString("0.##");
        }

        public string Tangente(double xi, int ite, double toler)
        {
            var funcion = new Funcion();
            Boolean flagSalida = false;
            double raizFinal = 0;
            int c = 0;
            double Tole = toler;
            double xant = 0;
            int Ite = ite;
            double der = (funcion.Function(xi + Tole) - funcion.Function(xi)) / Tole;
            while (flagSalida == false)
            {
                if (Math.Abs(funcion.Function(xi))<Tole)
                {
                    raizFinal = xi;
                    flagSalida = true;
                }
                else // xi es mayor a la tolerancia
                {
                    c++;
                    double xr = xi - funcion.Function(xi) / der;
                    double error = Math.Abs((xr - xant) / xr);
                    if (Math.Abs(funcion.Function(xr)) < Tole || error < Tole || c >= Ite)
                    {
                        raizFinal = xr;
                        flagSalida = true;
                    }
                    else
                    {
                        xi = xr;
                        xant = xr;
                    }                
                }
            }
            return "El resultado de la raiz por la tangente es: " + raizFinal.ToString("0.##");
        }

        public string Secante(double x0, double x1, int ite, double toler)
        {
            var funcion = new Funcion();
            Boolean flagSalida = false;
            double raizFinal = 0;
            int c = 0;
            double Tole = toler;
            double xant = x0;
            int Ite = ite;
            double sec = (funcion.Function(x1)*x0 - funcion.Function(x0)*x1) / funcion.Function(x1)- funcion.Function(x0);
            while (flagSalida == false)
            {
                if (funcion.Function(x0) * funcion.Function(x1) == 0)
                {
                    if (funcion.Function(x0) == 0)  
                    {
                        raizFinal = x0;
                        flagSalida = true;
                    }
                    else
                    {
                        raizFinal = x1;
                        flagSalida = true;
                    }
                }
                else // xi es mayor a la tolerancia
                {
                    c++;
                    double xr = x1 - funcion.Function(x1) / sec;
                    double error = Math.Abs((xr - xant) / xr);

                    if (Math.Abs(funcion.Function(xr)) < Tole || error < Tole || c >= Ite)
                    {
                        raizFinal = xr;
                        flagSalida = true;
                    }
                    else
                    {
                        x0 = x1;
                        x1 = xr;
                        xant = xr;
                    }
                }
            }
            return "El resultado de la raiz por la secante es: " + raizFinal.ToString("0.####");
        }

        public string ReglaFalsa(double xi, double xd, int ite, double toler)
        {
            var funcion = new Funcion();
            Boolean flagSalida = false, flgNoRaiz = false;
            double raizFinal = 0;
            int c = 0;
            double Tole = toler;
            double xant = 0;
            int Ite = ite;
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
                else if (funcion.Function(xi) * funcion.Function(xd) > 0) //Mayor a cero, ingresa nuevos valores.
                {
                    flgNoRaiz = true;
                    flagSalida = true;
                }
                else //menor a cero
                {
                    //double xr = (xi + xd) / 2;
                    double xr = (funcion.Function(xd) * xi - funcion.Function(xi) * xd) / (funcion.Function(xd) - funcion.Function(xi));
                    double error = Math.Abs((xr - xant) / xr);
                    c++;

                    if (Math.Abs(funcion.Function(xr)) < Tole || error < Tole || c >= Ite)
                    {
                        raizFinal = xr;
                        flagSalida = true;
                    }
                    else if (funcion.Function(xi) * funcion.Function(xr) > 0)
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
            if (flgNoRaiz == true)
            {
                return "No se encuentra ninguna raiz entre esos dos valores. Ingrese nuevos.";
            }
            else return "El resultado de la raiz entre la regla falsa es " + raizFinal.ToString("0.##");
        }
    }
}

