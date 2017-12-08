using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ExerciseRedPill.Service.Business.UnitTest
{
    [TestFixture]
    public class StringOperatorTests
    {
        [Test]
        public void Test_Reverse_Of_ABC_Is_CBA()
        {
            var stringOperator = new StringOperator();
            var reverse = stringOperator.GetReverse("ABC");
            Assert.AreEqual(reverse, "CBA");
        }

        [Test]
        public void Test_Reverse_Of_NULL_Is_NULL()
        {
            var stringOperator = new StringOperator();
            var reverse = stringOperator.GetReverse(null);
            Assert.AreEqual(reverse, null);
        }

        [Test]
        public void Test_Reverse_Of_EMPTY_Is_EMPTY()
        {
            var stringOperator = new StringOperator();
            var reverse = stringOperator.GetReverse(string.Empty);
            Assert.AreEqual(reverse, string.Empty);
        }

        [Test]
        public void Test_Reverse_Of_WHITESPACE_Is_WHITESPACE()
        {
            var stringOperator = new StringOperator();
            var reverse = stringOperator.GetReverse(" ");
            Assert.AreEqual(reverse, " ");
        }
    }
}