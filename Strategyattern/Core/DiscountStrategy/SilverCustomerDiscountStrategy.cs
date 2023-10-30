namespace Strategyattern.Core.DiscountStrategy
{
    public class SilverCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double totalPrice)
        {
            return totalPrice>=10000?.05:0;
        }
    }
}
