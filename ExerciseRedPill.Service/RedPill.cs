using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ExerciseRedPill.Service.Business;
using knockknock.readify.net;

namespace ExerciseRedPill.Service
{
    public class RedPill : IRedPill
    {
        private readonly IFibonacciProvider _fibonacciProvider;
        private readonly IStringOperator _stringOperator;
        private readonly IShapeIdentifier _shapeIdentifier;

        public RedPill(IFibonacciProvider fibonacciProvider, IStringOperator stringOperator, IShapeIdentifier shapeIdentifier)
        {
            _shapeIdentifier = shapeIdentifier;
            _stringOperator = stringOperator;
            _fibonacciProvider = fibonacciProvider;
        }

        public Guid WhatIsYourToken()
        {
            return Guid.NewGuid();
        }

        public long FibonacciNumber(long n)
        {
            return _fibonacciProvider.GetByIndex(n);
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            return _shapeIdentifier.IdentifyTriangleType(a, b, c);
        }

        public string ReverseWords(string s)
        {
            return _stringOperator.GetReverse(s);
        }
    }
}