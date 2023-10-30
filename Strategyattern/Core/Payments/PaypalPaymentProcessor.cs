using SalesSystemPaymentAbstraction_FactoryPattern_;
using PaymentLib = SalesSystemPaymentAbstraction_FactoryPattern_;
namespace Strategyattern.Core.Payment
{
    internal class PaypalPaymentProcessor : PaymentLib.ProcessorPayment
    {
        protected override IPaymentMethod CreatePaymentMethod()
        {
            return new PaypalPaymentMethod();
        }
    }
}
