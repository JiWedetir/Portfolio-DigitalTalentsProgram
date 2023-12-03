namespace Mergesort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MergeSort for Arrays:");
            // Testing with integer array
            int[] intArray = { 12, 4, 7, 2, 18, 5, 1, 6, 4 };
            Console.WriteLine("\tOriginal Integer Array: " + string.Join(", ", intArray));

            MyMergeSort<int> intMergeSortArr = new MyMergeSort<int>();
            int[] sortedIntArray = intMergeSortArr.MergeSort(intArray);

            Console.WriteLine("\tSorted Integer Array: " + string.Join(", ", sortedIntArray));
            Console.WriteLine();

            // Testing with double array
            double[] doubleArray = { 3.14, 2.71, 1.618, 0.577, 1.414, 2.71 };
            Console.WriteLine("\tOriginal Double Array: " + string.Join(", ", doubleArray));

            MyMergeSort<double> doubleMergeSortArr = new MyMergeSort<double>();
            double[] sortedDoubleArray = doubleMergeSortArr.MergeSort(doubleArray);

            Console.WriteLine("\tSorted Double Array: " + string.Join(", ", sortedDoubleArray));
            Console.WriteLine();

            // Testing with string array
            string[] stringArray = { "apple", "orange", "banana", "grape", "kiwi", "apple" };
            Console.WriteLine("\tOriginal String Array: " + string.Join(", ", stringArray));

            MyMergeSort<string> stringMergeSortArr = new MyMergeSort<string>();
            string[] sortedStringArray = stringMergeSortArr.MergeSort(stringArray);

            Console.WriteLine("\tSorted String Array: " + string.Join(", ", sortedStringArray));


            Console.WriteLine();
            Console.WriteLine("MergeSort for Lists:");
            // Testing with integer list
            List<int> intList = new List<int> { 12, 4, 7, 2, 18, 5, 1, 6, 4 };
            Console.WriteLine("\tOriginal Integer List: " + string.Join(", ", intList));

            MyMergeSort<int> intMergeSortList = new MyMergeSort<int>();
            List<int> sortedIntList = intMergeSortList.MergeSort(intList);

            Console.WriteLine("\tSorted Integer List: " + string.Join(", ", sortedIntList));
            Console.WriteLine();

            // Testing with double list
            List<double> doubleList = new List<double> { 3.14, 2.71, 1.618, 0.577, 1.414, 2.71 };
            Console.WriteLine("\tOriginal Double List: " + string.Join(", ", doubleList));

            MyMergeSort<double> doubleMergeSortList = new MyMergeSort<double>();
            List<double> sortedDoubleList = doubleMergeSortList.MergeSort(doubleList);

            Console.WriteLine("\tSorted Double List: " + string.Join(", ", sortedDoubleList));
            Console.WriteLine();

            // Testing with string list
            List<string> stringList = new List<string> { "apple", "orange", "banana", "grape", "kiwi", "apple" };
            Console.WriteLine("\tOriginal String List: " + string.Join(", ", stringList));

            MyMergeSort<string> stringMergeSortList = new MyMergeSort<string>();
            List<string> sortedStringList = stringMergeSortList.MergeSort(stringList);

            Console.WriteLine("\tSorted String List: " + string.Join(", ", sortedStringList));
        }
    }
}