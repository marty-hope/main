using System.Linq;
using NUnit.Framework;
using mhope.Math.FSharp;
using Fib = mhope.Math.FSharp.Fibonnaci;

namespace mhope.Math.UnitTests
{
    [TestFixture]
    public class FibonacciFSharpTests
    {
        [Test]
        public void Test_Fibonacci_At_Index_Zero()
        {
            const long expectedValue = 0;
            var number = Fib.GetFibonacciNumberAtIndex(0);
            Assert.IsTrue(number == expectedValue);
        }

        [Test]
        public void Test_Fibonacci_At_Index_One()
        {
            const long expectedValue = 1;
            var number = Fib.GetFibonacciNumberAtIndex(1);
            Assert.IsTrue(number == expectedValue);
        }

        [Test]
        public void Test_Fibonacci_At_Index_Five()
        {
            const long expectedValue = 5;
            var number = Fib.GetFibonacciNumberAtIndex(5);
            Assert.IsTrue(number == expectedValue);
        }

        [Test]
        public void Test_Fibonacci_At_Index_10()
        {
            var expectedValue = Fib.GetFibonacciNumberAtIndex(9) + Fib.GetFibonacciNumberAtIndex(8);

            var number = Fib.GetFibonacciNumberAtIndex(10);
            Assert.IsTrue(number == expectedValue);
        }
        [Test]
        public void Test_Fibonacci_Sequence_At_Index_Five()
        {
            const int expectedLength = 6;
            const long expectedFinalValue = 5;
            var fibSequence = Fib.GetFibonacciSequence(5).ToList();
            Assert.IsTrue(fibSequence.Count() == expectedLength);
            Assert.IsTrue(fibSequence[5] == expectedFinalValue);
        }
    }
}
