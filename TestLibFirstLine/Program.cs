using System;
using System.Collections.Generic;
using System.Linq;

namespace TestLibFirstLine
{
    public class Triangle
    {
        public enum TriagType
        {
            Right,
            AcuteAngled,
            Obtuse,
            NotTriangle
        }
        static public TriagType GetTriagType(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                var Sides = new List<double> { a, b, c };
                var MaxSide = Sides.Where(x => Sides.Where(y => y < x).Count() == 2).FirstOrDefault();
                double OtherSidesKvSum = 0;
                Sides.Where(y => y != MaxSide).ToList().ForEach(x => OtherSidesKvSum += x * x);
                int MaxSideKv = (int)(MaxSide * MaxSide);
                if (MaxSideKv == (int)OtherSidesKvSum)
                    return TriagType.Right;
                if (MaxSideKv < (int)OtherSidesKvSum)
                    return TriagType.AcuteAngled;
                if (MaxSideKv > (int)OtherSidesKvSum)
                    return TriagType.Obtuse;
            }
            return TriagType.NotTriangle;
        }
    }
}
