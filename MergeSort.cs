using System;

namespace MergeSort
{
   class Program
    {
        public  static int[] Mergesort(int[] input,int start,int end)
        {

            if (start >= end)
            {
                return new int[] { input[end] };
            }
            int mid = (start + end) / 2;

            int[] left = Mergesort(input, start, mid);

            int[] right = Mergesort(input, mid + 1, end);
            
            int[] MergeArray = Merge(left, right);
            return MergeArray;

        }
        public static int[] Merge(int[] left, int[] right)
        {
            int[] MergedArray = new int[left.Length + right.Length];
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                {
                    MergedArray[k] = left[i];
                    i++;
                }
                else
                {
                    MergedArray[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < left.Length)
            {
                MergedArray[k] = left[i];
                k++;
                i++;
            }
            while (j < right.Length)
            {
                MergedArray[k] = right[j];
                k++;
                j++;
            }
            return MergedArray;
        }
        static void Main()
        {

            Console.WriteLine("Enter the number of  elements");
              
            int max = Convert.ToInt32(Console.ReadLine());

            int[] Array = new int[max];
            
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("Enther the [" + (i + 1) + "] Element");
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int[] output = Mergesort(Array, 0, Array.Length-1);
            Console.WriteLine();
            Console.WriteLine("Sorted Elements");
            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }

        }
    }
}
