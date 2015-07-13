using BreakingSingleResponsibility;
using NUnit.Framework;

namespace Given_an_order
{
    [TestFixture]
    public class Given_an_order
    {
        [Test]
        public void When_I_call_add_then_no_exception_is_thrown()
        {
            var customer = new Customer();
            customer.Add();
            Assert.DoesNotThrow(() => customer.Add());
        }
    }
}
