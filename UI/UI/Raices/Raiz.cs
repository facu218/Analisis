using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;

namespace Metods
{
    public class ResultadoRaiz
    {        
        public string Biseccion (double xi, double xd, int ite, double toler, string func)
        {
            //var funcion = new Funcion();
            Function f = new Function("f(x) = " + func);
            Boolean flagSalida = false, flgNoRaiz = false;
            double raizFinal =0;
            int c=0;
            double Tole = toler;
            double xant = 0;
            double error = 0;
            int Ite = ite;
            while (flagSalida == false)
            {
                if (f.calculate(xi) * f.calculate(xd) == 0)
                {
                    if (f.calculate(xi) == 0)
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
                else if (f.calculate(xi) * f.calculate(xd) > 0)
                {
                    flgNoRaiz = true;
                    flagSalida = true;
                }
                else 
                {
                    double xr = (xi + xd) / 2;
                    error = Math.Abs((xr - xant) / xr);
                    c++;

                    if (Math.Abs(f.calculate(xr))< Tole  || error< Tole|| c>= Ite )
                    {
                        raizFinal = xr;
                        flagSalida = true;
                    }
                    else if (f.calculate(xi)*f.calculate(xr)>0)
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
            }else return "El resultado de la raiz entre la biseccion es " + raizFinal.ToString("0.######") + ".  Iter: " + c + ".  Error: " + error.ToString("0.######");
        }

        public string Tangente(double xi, int ite, double toler, string func)
        {
            //var funcion = new Funcion();
            Function f = new Function("f(x) = " + func);
            Boolean flagSalida = false;
            double raizFinal = 0;
            int c = 0;
            double Tole = toler;
            double xant = 0;
            double error = 0;
            int Ite = ite;
            double der = (f.calculate(xi + Tole) - f.calculate(xi)) / Tole;
            while (flagSalida == false)
            {
                if (Math.Abs(f.calculate(xi))<Tole)
                {
                    raizFinal = xi;
                    flagSalida = true;
                }
                else 
                {
                    c++;
                    double xr = xi - f.calculate(xi) / der;
                    error = Math.Abs((xr - xant) / xr);
                    if (Math.Abs(f.calculate(xr)) < Tole || error < Tole || c >= Ite)
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
            return "El resultado de la raiz por la tangente es: " + raizFinal.ToString("0.######") + ".  Iter: " + c + ".  Error: " + error.ToString("0.######");
        }

        public string Secante(double x1, double x0, int ite, double toler, string func)
        {
            //var funcion = new Funcion();
            Function f = new Function("f(x) = " + func);
            Boolean flagSalida = false;
            double raizFinal = 0;
            int c = 0;
            double Tole = toler;
            double xant = x0;
            double error = 0;
            double x2 = 0;
            int Ite = ite;
            double sec(double xa0, double xa1)
            {
                return ((f.calculate(xa1) * xa0 - f.calculate(xa0) * xa1) / (f.calculate(xa1) - f.calculate(xa0)));
            };

            while (flagSalida == false)
            {
                if (f.calculate(x0) * f.calculate(x1) == 0)
                {
                    if (f.calculate(x0) == 0)  
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
                else
                {
                    c++;
                    x2 = sec(x0,x1);
                    error = Math.Abs((x2 - xant) / x2);

                    if (Math.Abs(f.calculate(x1)) < Tole || error < Tole || c >= Ite)

                    {
                        raizFinal = x2;
                        flagSalida = true;
                    }
                    else
                    {
                        x0 = x1;
                        x1 = x2;
                        xant = x2;
                    }
                }
            }
            return "El resultado de la raiz por la secante es: " + raizFinal.ToString("0.######") + ".  Iter: " + c + ".  Error: " + error.ToString("0.######");
        }

        public string ReglaFalsa(double xi, double xd, int ite, double toler, string func)
        {
            //var funcion = new Funcion();
            Function f = new Function("f(x) = " + func);
            Boolean flagSalida = false, flgNoRaiz = false;
            double raizFinal = 0;
            int c = 0;
            double Tole = toler;
            double xant = 0;
            double error = 0;
            int Ite = ite;
            while (flagSalida == false)
            {
                if (f.calculate(xi) * f.calculate(xd) == 0)
                {
                    if (f.calculate(xi) == 0)
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
                else if (f.calculate(xi) * f.calculate(xd) > 0) 
                {
                    flgNoRaiz = true;
                    flagSalida = true;
                }
                else 
                {
                    double xr = (f.calculate(xd) * xi - f.calculate(xi) * xd) / (f.calculate(xd) - f.calculate(xi));
                    error = Math.Abs((xr - xant) / xr);
                    c++;

                    if (Math.Abs(f.calculate(xr)) < Tole || error < Tole || c >= Ite)
                    {
                        raizFinal = xr;
                        flagSalida = true;
                    }
                    else if (f.calculate(xi) * f.calculate(xr) > 0)
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
            else return "El resultado de la raiz entre la regla falsa es " + raizFinal.ToString("0.########") + ".  Iter: "+ c + ".  Error: " + error.ToString("0.########");
        }
    }
}

