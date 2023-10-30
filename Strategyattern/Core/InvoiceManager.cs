using Strategyattern.Core.DiscountStrategy;

namespace Strategyattern.Core
{
    public class InvoiceManager
    {
        private ICustomerDiscountStrategy _customerDiscountStrategy;
        public void SetDiscountStrategy(ICustomerDiscountStrategy strategy)
        {
            _customerDiscountStrategy = strategy;
        }
        public Invoice CreateInvoice(Customer customer, double quantity, double unitPrice)
        {
            var invoice = new Invoice
            {
                Customer = customer,
                Lines = new[]
        {
            new InvoiceLine {Quantity = quantity,UnitPreice=unitPrice},
        }
            };

            invoice.DiscountPercentage = _customerDiscountStrategy.CalculateDiscount(invoice.TotalPrice);
            return invoice;

        }
    }
}
