using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProject
{
    class Circle
    {
        public double Area(double Radius)
            // calculates and returns area of circle with radius, rounds sum to two decimal points
        {
            double sum = Math.PI * Math.Pow(Radius, 2);
            double roundedSum = Math.Round(sum, 2);
            return roundedSum;

        }
        public double Perimeter(double Radius)
            // calculates and returns perimeter of circel with radius, rounds sum down to two decimal places
        {
            double sum = 2 * Math.PI * Radius;
            double roundedSum = Math.Round(sum, 2);
            return roundedSum;
        }
    }
}
