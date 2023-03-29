using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._2
{
    public class Upper_side_acsesor: Down_side_acsesor
    {
        private double vveerh_ = -1;

        public double Vveerh { 
            get 
            {
              return vveerh_;
            }
            set 
            {
                if (value == niz_)
                    vveerh_ = 0;
                else
                    vveerh_ = value;
            }
        }
    }
}
