using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;

namespace UI.AreaFuncion
{
    public class MetodosArea
    {
        public double Trapecio (string f, double a, double b)
        {
            Function fun = new Function("f(x) = " + f);
            double sol = Math.Abs(((fun.calculate(b) + fun.calculate(a)) * (b - a)) / 2); //formula
            return sol;
        }

        public double TrapecioMultiple (string f, double a, double b, int inter)
        {
            Function fun = new Function("f(x) = " + f);
            double h = (b - a) / inter; //intervalos
            double suma = 0;
            for (int i=1; i<inter; i++)
            {
                suma += fun.calculate(a + i*h); //suma los valores intermedios
            }
            double sol = Math.Abs((h/2)*(fun.calculate(a) + 2 * suma + fun.calculate(b))); //formula del metodo
            return sol;
        }

        public double Simpson13 (string f, double a, double b)
        {
            Function fun = new Function("f(x) = " + f);
            double h = (b - a) / 2;                            //Punto medio de los intervalos.
            double sol = Math.Abs((h/3) * (fun.calculate(a) + 4 * fun.calculate(a + h) + fun.calculate(b)));  //formula del metodo
            return sol;
        }

        public double Simpson13_Multiple (string f, double a, double b, int inter)
        {
            Function fun = new Function("f(x) = " + f);
            double h = (b - a) / inter;
            double resF = 0;
            double sumaP = 0;
            double sumaI = 0;
            if (inter % 2 != 0) //Revisa si la cant. de intervalos es par.
            {   //Si es impar calcula los 3 ultimos intervalos con Simpson 3/8.
                double bl = b;   
                b = b - 3 * h;
                resF = resF + Simpson38(f, b, bl);
                inter = inter - 3;  //resta 3 a la cantidad de intervalos
            }
            for (int i=1; i<inter; i++)
            {
                if (i % 2 == 0) //Verifica que la posicion sea par.
                {
                    sumaP += fun.calculate(a + i * h);  //Suma los valores de pos. pares
                }
                else
                {
                    sumaI += fun.calculate(a + i * h);  //Suma los valores de pos. impares
                }               
            }
            double sol = Math.Abs(resF + ((h / 3.0) * (fun.calculate(a) + (2 * sumaP) + (4 * sumaI) + fun.calculate(b))));
            return sol;
        }

        public double Simpson38 (string f, double a,double b)
        {
            Function fun = new Function("f(x) = " + f);
            double h = (b - a) / 3;    //Intervalo dividido 3.
            double sol = Math.Abs((3 * h / 8.0) * (fun.calculate(a) + (3 * fun.calculate(a + h)) + (3 * fun.calculate(a + (2 * h))) + fun.calculate(b)));
            return sol;
        }
    }
}
