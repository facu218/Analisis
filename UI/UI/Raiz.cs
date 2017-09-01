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
            double error = 0;
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
                else if (funcion.Function(xi) * funcion.Function(xd) > 0)
                {
                    flgNoRaiz = true;
                    flagSalida = true;
                }
                else 
                {
                    double xr = (xi + xd) / 2;
                    error = Math.Abs((xr - xant) / xr);
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
            }else return "El resultado de la raiz entre la biseccion es " + raizFinal.ToString("0.######") + ".  Iter: " + c + ".  Error: " + error.ToString("0.######");
        }

        public string Tangente(double xi, int ite, double toler)
        {
            var funcion = new Funcion();
            Boolean flagSalida = false;
            double raizFinal = 0;
            int c = 0;
            double Tole = toler;
            double xant = 0;
            double error = 0;
            int Ite = ite;
            double der = (funcion.Function(xi + Tole) - funcion.Function(xi)) / Tole;
            while (flagSalida == false)
            {
                if (Math.Abs(funcion.Function(xi))<Tole)
                {
                    raizFinal = xi;
                    flagSalida = true;
                }
                else 
                {
                    c++;
                    double xr = xi - funcion.Function(xi) / der;
                    error = Math.Abs((xr - xant) / xr);
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
            return "El resultado de la raiz por la tangente es: " + raizFinal.ToString("0.######") + ".  Iter: " + c + ".  Error: " + error.ToString("0.######");
        }

        public string Secante(double x1, double x0, int ite, double toler)
        {
            var funcion = new Funcion();
            Boolean flagSalida = false;
            double raizFinal = 0;
            int c = 0;
            double Tole = toler;
            double xant = x0;
            double error = 0;
            double x2 = 0;
            int Ite = ite;
<<<<<<< HEAD
            double sec(double xa0, double xa1)
            {
                return ((funcion.Function(xa1) * xa0 - funcion.Function(xa0) * xa1) / (funcion.Function(xa1) - funcion.Function(xa0)));
            };
=======
            //double sec = (funcion.Function(x1)*x0 - funcion.Function(x0)*x1) / funcion.Function(x1)- funcion.Function(x0);
>>>>>>> d943f7d415581911d22427ed8aaebb24a2d93690
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
                else
                {
                    c++;
<<<<<<< HEAD
                    x2 = sec(x0,x1);
                    error = Math.Abs((x2 - xant) / x2);

                    if (Math.Abs(funcion.Function(x1)) < Tole || error < Tole || c >= Ite)
=======
                    double x2 = (funcion.Function(x1) * x0 - funcion.Function(x0) * x1) / (funcion.Function(x1) - funcion.Function(x0));
                    double error = Math.Abs((x2 - xant) / x2);

                    if (Math.Abs(funcion.Function(x2)) < Tole || error < Tole || c >= Ite)
>>>>>>> d943f7d415581911d22427ed8aaebb24a2d93690
                    {
                        raizFinal = x2;
                        flagSalida = true;
                    }
                    else
                    {
                        x0 = x1;
                        x1 = x2;
<<<<<<< HEAD
                        xant = x1;
=======
                        xant = x2;
>>>>>>> d943f7d415581911d22427ed8aaebb24a2d93690
                    }
                }
            }
            return "El resultado de la raiz por la secante es: " + raizFinal.ToString("0.######") + ".  Iter: " + c + ".  Error: " + error.ToString("0.######");
        }

        public string ReglaFalsa(double xi, double xd, int ite, double toler)
        {
            var funcion = new Funcion();
            Boolean flagSalida = false, flgNoRaiz = false;
            double raizFinal = 0;
            int c = 0;
            double Tole = toler;
            double xant = 0;
            double error = 0;
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
                else if (funcion.Function(xi) * funcion.Function(xd) > 0) 
                {
                    flgNoRaiz = true;
                    flagSalida = true;
                }
                else 
                {
                    double xr = (funcion.Function(xd) * xi - funcion.Function(xi) * xd) / (funcion.Function(xd) - funcion.Function(xi));
                    error = Math.Abs((xr - xant) / xr);
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
            else return "El resultado de la raiz entre la regla falsa es " + raizFinal.ToString("0.########") + ".  Iter: "+ c + ".  Error: " + error.ToString("0.########");
        }
    }
}

