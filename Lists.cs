using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Lists
    {
        

public class ListOperations
    {
        public static int SumGreaterThan10(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number > 10)
                {
                    sum += number;
                }
            }
            return sum;
        }

        public static int SumGreaterThan10Linq(List<int> numbers)
        {
            return numbers.Where(n => n > 10).Sum();
        }
    }

    
}
}
