using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTestLib.Figures
{
    public class Triangle : Figure
    {
        double side1;
        double side2;
        double side3;

        public Triangle(double value1, double value2, double value3) 
        {
            if (value1 <= 0 || value2 <=0 || value3 <= 0) 
                throw new ArgumentOutOfRangeException("Одна из сторон меньше или равна 0");

            if ((value2 + value3) <= value1 || (value1 + value3) <= value2 || (value1 + value2) <= value3)
                throw new ArgumentException("Треугольник существует только тогда, когда сумма двух его сторон больше третьей");

            side1 = value1;
            side2 = value2;
            side3 = value3;
        }

        public override double GetSquare()
        {
            double HalfPerimeter = (side1 + side2 + side3)/2;

            var result = Math.Sqrt(HalfPerimeter * (HalfPerimeter - side1)*(HalfPerimeter - side2)*(HalfPerimeter - side3));

            return result;
        }

        public bool CheckRightAngle()
        {
            if((side2*side2 + side3*side3) == side1*side1 || (side1*side1 + side3*side3) == side2*side2 || (side1*side1 + side2*side2) == side3*side3)
                return true;
            else
                return false;
        }
    }
}
