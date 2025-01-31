using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Colors
    {
       
public class ColorPrinter
    {
        public static void PrintColors(List<string> colors)
        {
            Console.WriteLine("Colors in the list:");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
        }

        public static List<string> GetColorsFromUser()
        {
            Console.WriteLine("Enter colors, one per line (press Enter twice to finish):");
            List<string> colors = new List<string>();
            string inputColor;

            while ((inputColor = Console.ReadLine()) != "")
            {
                colors.Add(inputColor);
            }
            return colors;
        }
    }

    
}
}
