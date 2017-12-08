using NUnit.Framework;
using System;

namespace ExerciseRedPill.Service.Business.UnitTest
{
    [TestFixture]
    public class FibonacciProviderTests
    {
        [Test]
        public void Test_Get_Eighth_Fibonacci_Number_Assert_Is_34()
        {
            var provider = new FibonacciProvider();
            var number = provider.GetByIndex(8);
            Assert.AreEqual(34, number);
        }

        [Test]
        public void Test_Get_Sixth_Fibonacci_Number_Assert_Is_13()
        {
            var provider = new FibonacciProvider();
            var number = provider.GetByIndex(6);
            Assert.AreEqual(13, number);
        }

        [Test]
        public void Test_Get_Sixth_Fibonacci_Number_Assert_Is_Not_34()
        {
            var provider = new FibonacciProvider();
            var number = provider.GetByIndex(15);
            Assert.AreNotEqual(34, number);
        }
    }
}