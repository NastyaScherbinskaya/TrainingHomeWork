using System;

namespace TrainingHW2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Console.WriteLine("Array elements squared: \n");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * i;
                Console.WriteLine($"array[{i}] = {array[i]} \n");
            }

        }
    }
}
