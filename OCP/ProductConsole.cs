using System;
using System.Collections.Generic;

namespace BreakingOpenClosedPrinciple
{
    static class ProductConsole
    {
        public static void Main()
        {
            var product1 = new StandardProduct(4.52m);
            var product2 = new FeaturedProduct(3.99m);

            var products = new List<Product> {product1, product2};


            foreach (var product in products)
            {
                product.Render();
            }


            Console.WriteLine("FINISHED......press any key");
            Console.ReadKey();
        
        }
    }
}
