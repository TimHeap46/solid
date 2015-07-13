namespace BreakingOpenClosedPrinciple
{
    public abstract class Product
    {
        protected decimal Price { get; set; }

        public abstract void Render();
    }
}
