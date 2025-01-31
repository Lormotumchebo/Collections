using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Frequencies
    {
        

public class FrequencyCounter
    {
        public static Dictionary<int, int> CountFrequencies(List<int> numbers)
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (frequencyMap.ContainsKey(number))
                {
                    frequencyMap[number]++;
                }
                else
                {
                    frequencyMap[number] = 1;
                }
            }
            return frequencyMap;
        }

        public static Dictionary<int, int> CountFrequenciesLinq(List<int> numbers)
        {
            return numbers.GroupBy(n => n)
                          .ToDictionary(g => g.Key, g => g.Count());
        }

        public static Dictionary<int, int> CountFrequenciesFromInput(string input)
        {
            List<int> userNumbers = new List<int>();
            string[] inputNumbers = input.Split(' ');
            foreach (string numStr in inputNumbers)
            {
                if (int.TryParse(numStr, out int num))
                {
                    userNumbers.Add(num);
                }
                else
                {
                    Console.WriteLine($"Invalid input: {numStr}. Skipping.");
                }
            }

            Dictionary<int, int> userFrequencyMap = new Dictionary<int, int>();
            foreach (int number in userNumbers)
            {
                if (userFrequencyMap.ContainsKey(number))
                {
                    userFrequencyMap[number]++;
                }
                else
                {
                    userFrequencyMap[number] = 1;
                }
            }
            return userFrequencyMap;
        }


        public static void PrintFrequencyMap(Dictionary<int, int> freqMap)
        {
            foreach (var pair in freqMap)
            {
                Console.WriteLine($"Number: {pair.Key}, Frequency: {pair.Value}");
            }
        }
    }

    
}
}
