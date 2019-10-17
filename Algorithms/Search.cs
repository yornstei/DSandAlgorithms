using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    static class Search
    {
        public static bool BinarySearchRecursion(int[] numbers, int value)
        {
            int middleIndex = numbers.Length / 2;

            if (numbers[middleIndex] == value)
                return true;
            if (middleIndex == 0)
                return false;

            if (numbers[middleIndex] < value)
                return BinarySearchRecursion(numbers.Skip(middleIndex).ToArray(), value);
            else if (numbers[middleIndex] > value)
                return BinarySearchRecursion(numbers.Take(middleIndex - 1).ToArray(), value);

            return false;
        }

        public static bool BinarySearchRecursion(int[] numbers, int value, int left, int right)
        {
            int middleIndex = ((right - left) / 2) + left;

            if (numbers[middleIndex] == value)
                return true;
            if ((right - left) / 2 == 0)
                return false;

            if (numbers[middleIndex] < value)
                return BinarySearchRecursion(numbers, value, middleIndex + 1, right);
            else if (numbers[middleIndex] > value)
                return BinarySearchRecursion(numbers, value, left, middleIndex - 1);

            return false;
        }

        public static bool BinarySearchLoop(int[] numbers, int value)
        {
            int startAt = 0, endAt = numbers.Length - 1;
            int middleIndex = (endAt - startAt) / 2;

            while ((endAt - startAt) / 2 != 0 && middleIndex != numbers.Length - 1)
            {
                middleIndex = ((endAt - startAt) / 2) + startAt;
                if (numbers[middleIndex] == value)
                    return true;

                if (numbers[middleIndex] < value)
                    startAt = middleIndex;
                else if (numbers[middleIndex] > value)
                    endAt = middleIndex;
            }

            return false;
        }
    }
}
