using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._2
{
    internal class Trap_drug: Trap
    {
        double high_trap;

        public Trap_drug()
        {
            high_trap= 0;
        }

        public Trap_drug(double h_t, double niz, double vverh):base(niz, vverh)
        {
            high_trap = h_t;
        }

        public double Ploshad()
        {
            return 0.5 * ((niz_trap + vverh_trap) * high_trap);
        }
    }
}
