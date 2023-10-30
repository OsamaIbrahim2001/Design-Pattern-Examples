namespace Strategyattern.Core
{
    public class Invoice
    {
        public Customer Customer { get; set; }
    public IEnumerable<InvoiceLine> Lines { get; set; }
        public double TotalPrice => Lines.Sum(l => l.Quantity * l.UnitPreice);
        public double DiscountPercentage { get; set; }
        public double Taxes { get; set; }
        public double NetPrice => TotalPrice+Taxes - (TotalPrice * DiscountPercentage);
    }
}
