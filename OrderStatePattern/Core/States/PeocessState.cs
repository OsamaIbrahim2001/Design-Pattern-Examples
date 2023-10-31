namespace OrderStatePattern.Core.States
{
    internal class PeocessState : IOrderState
    {
        private readonly Order order;

        public PeocessState(Order order)
        {
            this.order = order;
        }
        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void Confirm()
        {
            throw new NotImplementedException();
        }

        public void Deliver()
        {
            throw new NotImplementedException();
        }

        public void Drift()
        {
            throw new NotImplementedException();
        }

        public void Process()
        {
            throw new NotImplementedException();
        }

        public void Return()
        {
            throw new NotImplementedException();
        }

        public void Ship()
        {
            order.State = new ShipState(order);
        }
    }
}
