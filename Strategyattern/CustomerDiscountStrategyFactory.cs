// Simple Factory Pattern
using Strategyattern.Core;
using Strategyattern.Core.DiscountStrategy;

namespace Strategyattern
{
    internal class CustomerDiscountStrategyFactory
    {
        public ICustomerDiscountStrategy CreateCustomerDiscountStrategyFactory(CustomerCategory category)
        {
            if (category == CustomerCategory.Gold)
                return new GoldCustomerDiscountStrategy();
            else if (category == CustomerCategory.Silver)
                return new SilverCustomerDiscountStrategy();
            return new NullCustomerDiscountStrategy();
        }
    }
}
