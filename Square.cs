using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    public class Square
    {
        public double SideLength { get; set; }

        public double CalculatePerimeter()
        {
            return 4 * SideLength;
        }

        public double CalculateArea()
        {
            return SideLength * SideLength;
        }
    }
}