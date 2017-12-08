using System;
using System.Linq;

namespace ExerciseRedPill.Service.Business
{
    public class StringOperator : IStringOperator
    {
        public string GetReverse(string data)
        {
            if (string.IsNullOrEmpty(data) || string.IsNullOrWhiteSpace(data))
                return data;

            return data.ToCharArray()
                .Aggregate
                    (
                        string.Empty, (current, c) => string.Format("{0}{1}", c, current)
                    );
        }
    }
}