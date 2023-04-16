using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTestLib.Figures
{
    public class Circle : Figure
    {
        double radius;
        public Circle(double value) 
        {
            if (value <= 0)
                throw new ArgumentException("Радиус меньше или равен 0");

            radius = value;
        }

        public override double GetSquare()
        {
            var result = radius*radius*Math.PI;
            return result;
        }
    }
}
