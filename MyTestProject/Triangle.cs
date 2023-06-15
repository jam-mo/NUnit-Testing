using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProject
{
    class Triangle
    {
        public double Area(double sideA, double sideB, double sideC)
            // takes 3 sides of a triangle, adds together and divides in half to get half perimeter for heron's formula, 
            // then herons formula used to get area of triangle
        {
            double halfPerimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));

        }
        public double Perimeter(double sideA, double sideB, double sideC) 
            // takes in length of triangle sides and returns sum to solve for perimeter
        {
            return sideA + sideB + sideC;
        }
    }
}
