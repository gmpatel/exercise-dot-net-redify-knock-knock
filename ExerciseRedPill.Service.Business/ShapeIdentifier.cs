using System;
using knockknock.readify.net;

namespace ExerciseRedPill.Service.Business
{
    public class ShapeIdentifier : IShapeIdentifier
    {
        public TriangleType IdentifyTriangleType(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0) 
            {
                return TriangleType.Error;
            }

            if (a == b && b == c)
            {
                return TriangleType.Equilateral;
            }

            if (a == b || a == c || b == c)
            {
                return TriangleType.Isosceles;
            }

            if (a != b && a != c && b != c)
            {
                return TriangleType.Scalene;
            }

            return TriangleType.Error;
        }
    }
}