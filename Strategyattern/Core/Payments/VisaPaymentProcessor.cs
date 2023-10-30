using SalesSystemPaymentAbstraction_FactoryPattern_;

namespace Strategyattern.Core.Payment
{
    internal class VisaPaymentProcessor : ProcessorPayment
    {
        protected override IPaymentMethod CreatePaymentMethod()
        {
            
           return new VisaPaymentMethod();
        }
    }
}
