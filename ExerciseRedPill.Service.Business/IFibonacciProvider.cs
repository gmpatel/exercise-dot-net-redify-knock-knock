using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseRedPill.Service.Business
{
    public interface IFibonacciProvider
    {
        long GetByIndex(long index);
    }
}