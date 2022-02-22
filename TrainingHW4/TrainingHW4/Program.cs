using System;

namespace TrainingHW4
{
    class Program
    {
        static int FindMinValue(int[] array)
        {
            int Min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < Min)
                {
                    Min = array[i];
                }

            }


            return Min;
        }

        static int FindMaxValue(int[] array)
        {
            int Max = array[0];


            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] > Max)
                {
                    Max = array[i];
                }

            }

            return Max;

        }


        static void ChangeMax_and_Min(int[] array)
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



        static void Main(string[] args)

        {

            int[] array1 = { 1, 4, 5, 7, 5, -2, 56 };
            Console.WriteLine($"Максимальное значение array1: {FindMaxValue(array1)} \n");
            Console.WriteLine($"Минимальное значение array1: {FindMinValue(array1)} \n");
            ChangeMax_and_Min(array1);

            Console.WriteLine("Измененный array1:\n");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);

            }



            int[] array2 = { 0, 4, 9, 33, 3, -6, 15, 3, 25 };

            Console.WriteLine($"\nМаксимальное значение array2: {FindMaxValue(array2)} \n");
            Console.WriteLine($"Минимальное значение array2: {FindMinValue(array2)} \n");

            ChangeMax_and_Min(array2);


            Console.WriteLine("Измененный array2:\n");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);

            }



        }
    }
}
