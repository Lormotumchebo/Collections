using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Products
    {
        

public class ProductCatalog
    {
        private Dictionary<string, double> _products; // Private field for the dictionary

        public ProductCatalog() // Constructor to initialize the dictionary
        {
            _products = new Dictionary<string, double>();
        }

        public void AddProduct(string productName, double price)
        {
            _products.Add(productName, price);
        }

        public void PrintProductPrices()
        {
            foreach (var product in _products)
            {
                Console.WriteLine($"{product.Key}: ${product.Value:F2}"); // Format price to 2 decimal places
            }
        }
    }



}
}
