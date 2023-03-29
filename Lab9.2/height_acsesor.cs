using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._2
{
    public class Height_acsesor
    {
        public double height = -1;

        public double Height
        {
            get
            {
                
                    return height;
            }
            set
            {
                if (value < 0)
                {
                    height = 0;
                }
                else
                    height = value;
            }
        }
    }
}