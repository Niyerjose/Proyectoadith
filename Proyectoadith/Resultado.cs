using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectoadith
{
    class Resultado
    {
        private double p;
        private double t;
       

        public Resultado(double p1, double t1)
        {
            p = p1;
            t = t1;
            
        }
        public double volumen2()
        {
            double volum;
        
            volum = t - p;
            return volum;
        }
    }
}

