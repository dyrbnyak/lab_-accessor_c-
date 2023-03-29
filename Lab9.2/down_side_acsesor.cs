using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._2
{
    public class Down_side_acsesor
    {
        public double niz_ ;

        public double Niz
        {
            get
            {
                    return niz_;
            }
            set 
            {
                if (value <= 0)
                { 
                        niz_ = 0;
                }
                else
                    niz_ = value;
            }
        }
    }
}
