using System;

// ReSharper disable InconsistentNaming
namespace InsertionSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with insertion sort algorithm.
        /// </summary>
        public static void InsertionSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array), $"{nameof(array)} is null");
            }

            if (array == Array.Empty<int>())
            {
                throw new ArgumentException($"{nameof(array)} is empty.", nameof(array));
            }

            for (int i = 1; i < array.Length; i++)
            {
                int sorted = i - 1;
                while (sorted > -1 && array[sorted] > array[sorted + 1])
                {
                    Swap(ref array[sorted], ref array[sorted + 1]);
                    sorted--;
                }
            }
        }

        public static void Swap(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive insertion sort algorithm.
        /// </summary>
        public static void RecursiveInsertionSort(this int[]? array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array), $"{nameof(array)} is null");
            }

            if (array == Array.Empty<int>())
            {
                throw new ArgumentException($"{nameof(array)} is empty.", nameof(array));
            }

            InsertionSortRecursive(array, 0);
        }

        public static void InsertionSortRecursive(this int[]? array, int i = 1)
        {
            if (i == array!.Length)
            {
                return;
            }

            int j = i - 1;
            if (j >= 0 && array[j] > array[j + 1])
            {
                Swap(ref array[j], ref array[j + 1]);
                InsertionSortRecursive(array, i - 1);
            }
            else
            {
                InsertionSortRecursive(array, i + 1);
            }
        }
    }
}
