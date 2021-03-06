using System;

namespace TrainingHW4
{
    class Program
    {
        static int[] FindMaxMin(int[] array)
        {
            int Max = array[0];
            int Min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > Max)
                {
                    Max = array[i];
                }
                if (array[i] < Min)
                {
                    Min = array[i];
                }
            }
 
            int[] ArrayWithMaxMinValues = { Max, Min };
            return ArrayWithMaxMinValues;
        }
        
        static void ChangeMaxMin(int[] array)
        {
            int[] MaxMin = FindMaxMin(array);
            int Max = MaxMin[0];
            int Min = MaxMin[1];

            Console.WriteLine($"\n Max value : {Max}, Min value : {Min}\n");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == Max)
                {
                    array[i] = Min;
                }
                else if (array[i] == Min)
                {
                    array[i] = Max;
                }
            }
        }
        static void OutputChangedArray(int[] array)
        {
            Console.WriteLine("Changed array:\n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] array1 = { 1, 4, 5, 7, 5, -2, 56 };

            FindMaxMin(array1);
            ChangeMaxMin(array1);
            OutputChangedArray(array1);

            int[] array2 = { 0, 4, 9, 33, 3, -6, 15, 33, 25 };

            FindMaxMin(array2);
            ChangeMaxMin(array2);
            OutputChangedArray(array2);
        }
    }
}
