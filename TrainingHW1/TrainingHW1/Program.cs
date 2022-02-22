using System;

namespace TrainingHW1
{
    class Program
    {
        static void Main(string[] args)
        {

            byte MinByteValue = byte.MinValue;
            byte MaxByteValue = byte.MaxValue;

            short MinShortValue = short.MinValue;
            short MaxShortValue = short.MaxValue;

            int MinIntValue = int.MinValue;
            int MaxIntValue = int.MaxValue;

            long MinLongValue = long.MinValue;
            long MaxLongValue = long.MaxValue;

            float MinFloatValue = float.MinValue;
            float MaxFloatValue = float.MaxValue;

            double MinDoubleValue = double.MinValue;
            double MaxDoubleValue = double.MaxValue;

            uint MinUintValue = uint.MinValue;
            uint MaxUintValue = uint.MaxValue;

            ulong MinUlongValue = ulong.MinValue;
            ulong MaxUlongValue = ulong.MaxValue;


            Console.WriteLine("Byte type:");
            Console.WriteLine($"Minimal Byte value: {MinByteValue}");
            Console.WriteLine($"Maximum Byte value: {MaxByteValue}\n");

            Console.WriteLine("Short type:");
            Console.WriteLine($"Minimal Short value: {MinShortValue}");
            Console.WriteLine($"Maximum Short value: {MaxShortValue}\n");

            Console.WriteLine("Int type:");
            Console.WriteLine($"Minimal Int value: {MinIntValue}");
            Console.WriteLine($"Maximum Int value: {MaxIntValue}\n");

            Console.WriteLine("Long type:");
            Console.WriteLine($"Minimal Long value: {MinLongValue}");
            Console.WriteLine($"Maximum Long value: {MaxLongValue}\n");

            Console.WriteLine("Float type:");
            Console.WriteLine($"Minimal Float value: {MinFloatValue}");
            Console.WriteLine($"Maximum Float value: {MaxFloatValue}\n");

            Console.WriteLine("Double type:");
            Console.WriteLine($"Minimal Double value: {MinDoubleValue}");
            Console.WriteLine($"Maximum Double value: {MaxDoubleValue}\n");

            Console.WriteLine("Uint type:");
            Console.WriteLine($"Minimal Uint value: {MinUintValue}");
            Console.WriteLine($"Maximum Uint value: {MaxUintValue}\n");

            Console.WriteLine("ULong type:");
            Console.WriteLine($"Minimal Ulong value: {MinUlongValue}");
            Console.WriteLine($"Maximum Ulong value: {MaxUlongValue}\n");


        }
    }
}
