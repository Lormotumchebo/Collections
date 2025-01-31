using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class ArraySumAverages
    {
     

public class ArrayOperations
    {
        public static (int sum, double average) CalculateSumAndAverage(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double average = (double)sum / numbers.Length;
            return (sum, average);
        }

        public static (int sum, double average) CalculateSumAndAverageLinq(int[] numbers)
        {
            int sum = numbers.Sum();
            double average = numbers.Average();
            return (sum, average);
        }

        public static (int sum, double average) CalculateSumAndAverageFromInput(string input)
        {
            string[] inputNumbers = input.Split(' ');
            int[] userNumbers = new int[inputNumbers.Length];

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (int.TryParse(inputNumbers[i], out int number))
                {
                    userNumbers[i] = number;
                }
                else
                {
                    Console.WriteLine($"Invalid input: {inputNumbers[i]}. Using 0 for this value.");
                    userNumbers[i] = 0;
                }
            }

            int sum = userNumbers.Sum();
            double average = userNumbers.Average();
            return (sum, average);
        }
    }

   
}
}
