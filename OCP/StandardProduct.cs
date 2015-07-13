using System;

namespace BreakingOpenClosedPrinciple
{
    public class StandardProduct : Product
    {
          public override void Render()
          {
               Price = Convert.ToDecimal("99");
               Console.WriteLine("Hi, I am a standard product that costs £{0}", Price);
          }

        public StandardProduct(decimal price)
        {
            Price = price;
        }
    }
}
