using System.Linq;
using NUnit.Framework;

namespace mhope.Math.UnitTests
{
	[TestFixture]
	public class FibonacciTests
	{
		[Test]
		public void Test_Fibonacci_At_Index_Zero()
		{
			const long expectedValue = 0;
			long number = Fibonacci.GetFibonacciNumberAtIndex(0);
			Assert.IsTrue(number == expectedValue);
		}

        [Test]
        public void Test_Fibonacci_At_Index_One()
        {
            const long expectedValue = 1;
            long number = Fibonacci.GetFibonacciNumberAtIndex(1);
            Assert.IsTrue(number == expectedValue);
        }

		[Test]
		public void Test_Fibonacci_At_Index_Five()
		{
			const long expectedValue = 5;
			long number = Fibonacci.GetFibonacciNumberAtIndex(5);
			Assert.IsTrue(number == expectedValue);
		}

		[Test]
		public void Test_Fibonacci_At_Index_10()
		{
			long expectedValue = Fibonacci.GetFibonacciNumberAtIndex(9) + Fibonacci.GetFibonacciNumberAtIndex(8);
			
			long number = Fibonacci.GetFibonacciNumberAtIndex(10);
			Assert.IsTrue(number == expectedValue);
		}
		[Test]
		public void Test_Fibonacci_Sequence_At_Index_Five()
		{
			const int expectedLength = 6;
			const long expectedFinalValue = 5;
			var fibSequence = Fibonacci.GetFibonacciSequence(5).ToList();
			Assert.IsTrue(fibSequence.Count() == expectedLength);
			Assert.IsTrue(fibSequence[5] == expectedFinalValue);
		}
	}
}
