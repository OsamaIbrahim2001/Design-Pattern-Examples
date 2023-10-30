using SalesSystemPaymentAbstraction_FactoryPattern_;

namespace Strategyattern.Core.ShoppingCart
{
    public abstract class ShoppingCart
    {
        public List<InvoiceLine> lines = new ();
        public void AddItem(int itemId,int quantity,double unitPrice)
        {
            lines.Add(new InvoiceLine {ItemId = itemId,Quantity = quantity,UnitPreice = unitPrice});
        }

        public void Checkout(Customer customer,ProcessorPayment processorPayment) {
        var invoice=new Invoice {Customer = customer,Lines=lines};
            AppyTaxes(invoice);
            ApplyDiscount(invoice);
            ProcessPayment(invoice,processorPayment);
        }
        private void AppyTaxes(Invoice invoice)
        {
            invoice.Taxes = invoice.TotalPrice * .15;
        }


        protected abstract void ApplyDiscount(Invoice invoice);
        

        private void ProcessPayment(Invoice invoice,ProcessorPayment processorPayment)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{GetType().Name} Invoice creared for customer {invoice.Customer.Name} with net price = {invoice.NetPrice}");

            var payment=processorPayment.ProcessPayment(invoice.Customer.Id,invoice.NetPrice);
            Console.WriteLine($"Customer charget with {payment.ChgargeAmount:0.00}, Payment ref {payment.ResfrenceNumber}");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
