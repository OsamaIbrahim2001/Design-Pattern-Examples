namespace SalesSystemPaymentAbstraction_FactoryPattern_
{
    public abstract class ProcessorPayment
    {
        public Payment ProcessPayment(int customerId, double amount) {

            var paymentMethod = CreatePaymentMethod();
            var payment=paymentMethod.Charge(customerId, amount);
            return payment;
        }

        protected abstract IPaymentMethod CreatePaymentMethod();
    }
}
