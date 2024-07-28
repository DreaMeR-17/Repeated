using System;

namespace Repeated
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int randomValue = 30;
            int maxValue = 6;
            int minValue = 1;
            int maxNumbersRepeat = 0;
            int currentNumbersRepeat = 1;
            int currentValue = int.MinValue;

            int[] numbers = new int[randomValue];

            Console.WriteLine($"Дан массив, размером {randomValue} чисел."); ;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentNumbersRepeat++;
                }
                else
                {
                    currentNumbersRepeat = 1;
                }

                if (currentNumbersRepeat > maxNumbersRepeat)
                {
                    maxNumbersRepeat = currentNumbersRepeat;
                    currentValue = numbers[i];
                }
            }

            Console.WriteLine($"\nЧисло {currentValue} повторяется {maxNumbersRepeat} раз(а)");
        }
    }
}
