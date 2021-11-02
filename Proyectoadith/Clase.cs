using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectoadith
{
    class Clase
    {
        private double h;
        private double r;
        private double m;

        public Clase(double r1, double h1, double m1)
        {
            r = r1;
            h = h1;
            m = m1;
        }
        public double volumen()
        {
            double volum;
            double pi = 3.1416;
            volum = ((r * r) * h * pi) * m;
            return volum;
        }
    }
}
