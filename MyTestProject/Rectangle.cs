using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProject
{
    class Rectangle
    {
        public double Area(double Height, double Width)
            // takes height and width, returns sum to solve for rectangle area
        {
            return Height * Width;
        }
        public double Perimeter(double Height, double Width)
        // takes height and width, returns sum to solve for rectangles perimeter
        {
            return 2 * Height + 2 * Width;
        }
    }
}
