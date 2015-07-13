using System.Collections.Generic;

namespace BreakingLiskovSubtitutionPrinciple
{
    public class Rectangle
    {
        private readonly List<ShapeLength> shapeLengths;

        public Rectangle(List<ShapeLength> shapeLengths )
        {
            this.shapeLengths = shapeLengths;
        }


        public double Area()
        {
            if (shapeLengths.Count == 1)
            {
                return shapeLengths[0].Length*shapeLengths[0].Length;
            }
           
                return shapeLengths[0].Length*shapeLengths[1].Length;
            
        }
    }

    public class Square : Rectangle
    {
        private List<ShapeLength> ShapeLengths { get; set; }

        public Square(List<ShapeLength> shapeLengths) : base(shapeLengths)
        {
            ShapeLengths = shapeLengths;
        }

       
    }

#region What's wrong with the above?
// Square is a sub class of Rectangle, but the Square object sets both the height 
// & width to the same value when either property is changed.
// While this makes sense in the real world, it does mean that the Square does not behave in the 
// same way as it’s parent class. 
//
// Real World Example: Filling your car up. Petrol & Diesel are both Types of Fuel, derived from Oil.
// However, substituting one for the other has a dramatic side affect on the system in which it is used.
#endregion
}
