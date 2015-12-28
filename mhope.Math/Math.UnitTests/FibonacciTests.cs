using System;
using mhope.Math;
using NUnit.Framework;
using System.Linq;

namespace Math.UnitTests
{
	[TestFixture]
	public class FibonacciTests
	{
		[Test]
		public void Test_Fibonacci_At_Index_Zero()
		{
			const long expectedValue = 0;
			var fib = new Fibonacci();
			long number = fib.GetFibonacciNumberAtIndex(0);
			Assert.IsTrue(number == expectedValue);
		}

        [Test]
        public void Test_Fibonacci_At_Index_One()
        {
            const long expectedValue = 1;
            var fib = new Fibonacci();
            long number = fib.GetFibonacciNumberAtIndex(1);
            Assert.IsTrue(number == expectedValue);
        }

		[Test]
		public void Test_Fibonacci_At_Index_Five()
		{
			const long expectedValue = 5;
			var fib = new Fibonacci();
			long number = fib.GetFibonacciNumberAtIndex(5);
			Assert.IsTrue(number == expectedValue);
		}

		[Test]
		public void Test_Fibonacci_At_Index_10()
		{
			var fib = new Fibonacci();
			long expectedValue = fib.GetFibonacciNumberAtIndex(9) + fib.GetFibonacciNumberAtIndex(8);
			
			long number = fib.GetFibonacciNumberAtIndex(10);
			Assert.IsTrue(number == expectedValue);
		}
		[Test]
		public void Test_Fibonacci_Sequence_At_Index_Five()
		{
			var fib = new Fibonacci();
			const int expectedLength = 6;
			const long expectedFinalValue = 5;
			var fibSequence = fib.GetFibonacciSequence(5);
			Assert.IsTrue(fibSequence.Count() == expectedLength);
			Assert.IsTrue(fibSequence.ToList()[5] == expectedFinalValue);
		}
	}
}
