using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class Resta:Ioperacion
    {
        public double Ejecutar(double m, double c)
        {
            return m - c;
        }
    }
}
