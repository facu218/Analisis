using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;

namespace Metods
{
    public class Funcion
    {
        public double Function (double x)
        {
            Function f = new Function("f(x) = abs((x^2)-4)+2*x");
            return f.calculate(x);
        }
    }
}
