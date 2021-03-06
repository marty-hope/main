﻿using System;
using System.Collections.Generic;

namespace mhope.Math
{
	/*
	 * Given a sequence f
	 * f[n] = f[n-1] + f[n-2]
	 * where n > 1
	 * f[0] = 0; f[1] = 1
	 */
	public static class Fibonacci
	{
		/// <summary>
		/// Creates a Fibonacci sequence up to and including the specified index
		/// </summary>
		/// <param name="index">index of the final value in the Fibonacci sequence</param>
		/// <returns>a Fibonacci sequence</returns>
		public static IEnumerable<long> GetFibonacciSequence(int index) 
		{
			for (int i = 0; i <= index; i++)
			{
				yield return GetFibonacciNumberAtIndex(i);
			}

		}

		//
		public static long GetFibonacciNumberAtIndex(int index)
		{
			if(index < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (index == 0)
			{
				return 0;
			}
			if(index == 1)
			{
				return 1;
			}
			return GetFibonacciNumberAtIndex(index - 1) + GetFibonacciNumberAtIndex(index - 2);
		}
	}
}
