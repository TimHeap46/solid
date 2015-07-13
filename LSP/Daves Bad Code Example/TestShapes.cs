using System.Collections.Generic;
using BreakingLiskovSubtitutionPrinciple;
using NUnit.Framework;

namespace TestBreakingLSP
{
    [TestFixture]
    public class TestShapes
    {
        [Test]
        public void ShouldCalculateAreaOfRectangle()
        {
            var shapeLengths = new List<ShapeLength> {new ShapeLength() {Length = 4}, new ShapeLength() {Length = 5}};
            var rectangle = new Rectangle(shapeLengths);

            Assert.That(rectangle.Area(), Is.EqualTo(20));
        }
        
        [Test]
        public void ShouldCalculateAreaOfSquare()
        {
            var shapeLength = new ShapeLength {Length = 4};
            var ShapeLengths = new List<ShapeLength> {shapeLength};
            Rectangle rectangle = new Square(ShapeLengths);

            Assert.That(rectangle.Area(), Is.EqualTo(16));
        }
    }

   
}
