using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Objects
{
     class Circle
    {
        private double Radius;

        public double Area { get; set; }
        public double circumference { get; set; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double CalculateArea()
        {
            {
                double area = Radius * Radius * Math.PI;
                area = Math.Round(area, 2);
                return area;
            }
        }
        public double CalculateCircumference()
        {

          double circumference = 2 * (Math.PI * Radius);
          circumference = Math.Round(circumference, 2);
          return circumference;
        }
    }
}   
