namespace SalesSystemPaymentAbstraction_FactoryPattern_
{
    public interface IPaymentMethod
    {
        Payment Charge(int customerId,double amount);
    }
}
