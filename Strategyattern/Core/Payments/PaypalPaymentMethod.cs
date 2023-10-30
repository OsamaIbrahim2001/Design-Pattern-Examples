using PaymentLib=SalesSystemPaymentAbstraction_FactoryPattern_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategyattern.Core.Payment
{
    internal class PaypalPaymentMethod : PaymentLib.IPaymentMethod
    {
        public PaymentLib.Payment Charge(int customerId, double amount)
        {
            return new PaymentLib.Payment
            {
                customerId = customerId,
                ChgargeAmount = amount + amount * 0.05,
                ResfrenceNumber = Guid.NewGuid(),
            };
        }
    }
}
