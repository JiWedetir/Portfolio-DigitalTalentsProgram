using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mergesort
{
    public class MyMergeSort<T> where T: IComparable<T>
    {
        /// <summary>
        /// Performs merge sort on the specified array.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        /// <returns>A new array containing the sorted elements.</returns>
        public T[] MergeSort(T[] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));

            if (array.Length <= 1) return array;

            int middle = array.Length / 2;

            T[] leftArray = new T[middle];
            Array.Copy(array, leftArray, middle);

            T[] rightArray = new T[array.Length - middle];
            Array.Copy(array, middle, rightArray, 0, array.Length - middle);

            leftArray = MergeSort(leftArray);
            rightArray = MergeSort(rightArray);

            return Merge(leftArray, rightArray);
        }

        /// <summary>
        /// Performs merge sort on the specified list.
        /// </summary>
        /// <param name="list">The list to be sorted.</param>
        /// <returns>A new list containing the sorted elements.</returns>
        public List<T> MergeSort(List<T> list)
        {
            if (list == null) throw new ArgumentNullException(nameof(list));

            if (list.Count <= 1) return list;

            int middle = list.Count / 2;

            List<T> leftList = list.GetRange(0, middle);
            List<T> rightList = list.GetRange(middle, list.Count - middle);

            leftList = MergeSort(leftList);
            rightList = MergeSort(rightList);

            return Merge(leftList, rightList);
        }

        /// <summary>
        /// Merges two sorted arrays into a single sorted array.
        /// </summary>
        /// <param name="leftArray">The left sorted array to be merged.</param>
        /// <param name="rightArray">The right sorted array to be merged.</param>
        /// <returns>A new array containing the merged and sorted elements from both input arrays.</returns>
        protected T[] Merge(T[] leftArray, T[] rightArray)
        {
            T[] result = new T[leftArray.Length + rightArray.Length];

            int leftIndex = 0;
            int rightIndex = 0;
            int resultIndex = 0;

            while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
            {
                if (leftArray[leftIndex].CompareTo(rightArray[rightIndex]) <= 0)
                {
                    result[resultIndex] = leftArray[leftIndex];
                    resultIndex++;
                    leftIndex++;
                }
                else
                {
                    result[resultIndex] = rightArray[rightIndex];
                    resultIndex++;
                    rightIndex++;
                }
            }

            while (leftIndex < leftArray.Length)
            {
                result[resultIndex] = leftArray[leftIndex];
                resultIndex++;
                leftIndex++;
            }

            while (rightIndex < rightArray.Length)
            {
                result[resultIndex] = rightArray[rightIndex];
                resultIndex++;
                rightIndex++;
            }

            return result;
        }

        /// <summary>
        /// Merges two sorted lists into a single sorted list.
        /// </summary>
        /// <param name="leftList">The left sorted list to be merged.</param>
        /// <param name="rightList">The right sorted list to be merged.</param>
        /// <returns>A new list containing the merged and sorted elements from both input lists.</returns>
        protected List<T> Merge(List<T> leftList, List<T> rightList)
        {
                List<T> result = new List<T>(leftList.Count + rightList.Count);

                int leftIndex = 0;
                int rightIndex = 0;

                while (leftIndex < leftList.Count && rightIndex < rightList.Count)
                {
                    if (leftList[leftIndex].CompareTo(rightList[rightIndex]) <= 0)
                    {
                        result.Add(leftList[leftIndex]);
                        leftIndex++;
                    }
                    else
                    {
                        result.Add(rightList[rightIndex]);
                        rightIndex++;
                    }
                }

                while (leftIndex < leftList.Count)
                {
                    result.Add(leftList[leftIndex]);
                    leftIndex++;
                }

                while (rightIndex < rightList.Count)
                {
                    result.Add(rightList[rightIndex]);
                    rightIndex++;
                }

                return result;
        }
    }
}
