namespace Strategyattern.Core.DiscountStrategy
{
    internal class NullCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double totalPrice)
        {
            return 0;
        }
    }
}
