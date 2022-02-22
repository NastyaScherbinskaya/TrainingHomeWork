using System;

namespace TrainingHW3
{
    class Program
    {
        static void ValuesForArray(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)Math.Pow(i, value);

            }
        }

        static float AverageSum(int[] array)
        {
            int SumArray = 0;
            for (int i = 0; i < array.Length; i++)
            {
                SumArray += array[i];

            }
            float AverageValue = (float)SumArray / array.Length;

            return AverageValue;

        }

        static void Main(string[] args)
        {

            int[] array = new int[10];

            for (int i = 1; i < 4; i++)
            {
                ValuesForArray(array, i);
                Console.WriteLine($"Среднее значение массива {i} : {AverageSum(array)} ");

            }

        }
    }
}
