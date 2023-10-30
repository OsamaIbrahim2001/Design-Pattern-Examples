namespace OrderStatePattern.Core
{
    internal class Order
    {
        public IEnumerable<OrderLine> Lines { get; set; }
        public OrderState State { get; set; }
    }
}
