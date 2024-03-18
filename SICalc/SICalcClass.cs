using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICalc
{
    internal class SICalcClass
    {
        double p, r;
        int t;

        public double P { get { return p; } set {  p = value; } }

        public double R { get { return r; } set { r = value; } }

        public int T { get { return t; } set { t = value; } }
        
        public double getSI() { return p*r*t/100; }
    }
}
