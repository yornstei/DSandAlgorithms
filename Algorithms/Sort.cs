using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Sort
    {
        //ckeck out https://www.youtube.com/watch?v=KF2j-9iSf4Q for explanation and code source
        public static void BubbleSort(int[] arr)
        {
            bool sorted = false;
            int sortedIndex = arr.Length;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < sortedIndex - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i, i + 1);
                        sorted = false;
                    }
                }
                sortedIndex--;
            }
        }

        public static void MergeSort(int[] arr)
        {
            MergeSortRecursion(arr, 0, arr.Length - 1, new int[arr.Length]);
        }

        private static void MergeSortRecursion(int[] arr, int start, int end, int[] temp)
        {
            if (start >= end) return;

            int middle = (start + end) / 2;
            MergeSortRecursion(arr, start, middle, temp);
            MergeSortRecursion(arr, middle + 1, end, temp);
            MergeSortedSides(arr, start, end, temp);
        }

        private static void MergeSortedSides(int[] arr, int leftStart, int rightEnd, int[] temp)
        {
            int leftEnd = (leftStart + rightEnd) / 2;
            int rightStart = leftEnd + 1;

            int right = rightStart;
            int left = leftStart;
            int index = leftStart;
            int size = rightEnd - leftStart + 1;

            while(left <= leftEnd && right <= rightEnd)
            {
                if (arr[left] <= arr[right])
                {
                    temp[index] = arr[left];
                    left++;
                }
                else
                {
                    temp[index] = arr[right];
                    right++;
                }

                index++;
            }

            Array.Copy(arr, left, temp, index, leftEnd - left + 1);
            Array.Copy(arr, right, temp, index, rightEnd - right + 1);
            Array.Copy(temp, leftStart, arr, leftStart, size);
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static void QuickSort(int[] arr) { }
    }
}
