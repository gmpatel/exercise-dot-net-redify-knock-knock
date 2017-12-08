using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseRedPill.Service.Business
{
    public class FibonacciProvider : IFibonacciProvider
    {
        public long GetByIndex(long index)
        {
            var sqrt5 = Math.Sqrt(5);
            var p1 = (1 + sqrt5) / 2;
            var p2 = -1 * (p1 - 1);

            var n1 = Math.Pow(p1, index + 1);
            var n2 = Math.Pow(p2, index + 1);

            return (long)((n1 - n2) / sqrt5);   
        }
    }
}