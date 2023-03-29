using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._2
{
    class Trap
    {
        public double sum_trap, niz_trap, vverh_trap;

        public Trap()
        {
            niz_trap = vverh_trap = 0;
        }
        public Trap(double niz, double vverh)
        {
            niz_trap = niz;
            vverh_trap = vverh;
        }

        public double PoluSumm_trap()
        {
            return (niz_trap + vverh_trap) / 2;
        }

    }
}
