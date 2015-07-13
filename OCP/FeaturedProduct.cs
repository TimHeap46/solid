using System;

namespace BreakingOpenClosedPrinciple
{
    public class FeaturedProduct : Product
    {
        public FeaturedProduct(decimal price)
        {
            Price = price;
        }
        public override void Render()
        {
            Price = 0; 
            Console.WriteLine("******* WOO HOOO *******",null);
            Console.WriteLine("******* FEATURED PRODUCT HERE **********",null);
            Console.WriteLine("******* I COST £{0} **********", Price);
        }
    }
}
