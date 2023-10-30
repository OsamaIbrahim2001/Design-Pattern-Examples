namespace Strategyattern.Core.DiscountStrategy
{
    public interface ICustomerDiscountStrategy
    {
        double CalculateDiscount(double totalPrice);
    }
}
