using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    static class Memoization
    {
        public static int FibRecursion(int x)
        {
            if (x == 0 || x == 1) return x;

            return FibRecursion(x - 1) + FibRecursion(x - 2);
        }

        public static int FibMemoized(int x, Dictionary<int, int> memoized = null)
        {
            if (x == 0 || x == 1) return x;

            Dictionary<int, int> memo = memoized ?? new Dictionary<int, int>();

            if (memo.TryGetValue(x, out int value))
                return value;
            else
            {
                int fib = FibMemoized(x - 1, memo) + FibMemoized(x - 2, memo);
                memo.Add(x, fib);
                return fib;
            }
        }
    }
}
