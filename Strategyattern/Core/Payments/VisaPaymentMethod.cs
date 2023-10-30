using SalesSystemPaymentAbstraction_FactoryPattern_;
using Payments= SalesSystemPaymentAbstraction_FactoryPattern_;

namespace Strategyattern.Core.Payment
{
    internal class VisaPaymentMethod : Payments.IPaymentMethod
    {
        public Payments.Payment Charge(int customerId, double amount)
        {
            double commission = amount >= 10000 ? amount * .02 : 0;
           return new Payments.Payment {
            customerId = customerId,
            ResfrenceNumber=Guid.NewGuid(),
            ChgargeAmount=amount+commission,
            };
        }
    }
}
