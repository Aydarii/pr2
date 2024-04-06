using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    public class Rectangle
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public double Perimetr()
        {
            return 2 * Side1 + 2 * Side2;
        }
        public double S()
        {
            return Side1 * Side2;
        }

    }
}
