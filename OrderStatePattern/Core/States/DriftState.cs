namespace OrderStatePattern.Core.States
{
    internal class DriftState : IOrderState
    {
        private readonly Order order;
        public DriftState(Order order)
        {
            this.order = order;
        }
        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void Confirm()
        {
            order.State=new ConfirmState(order);
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
            throw new NotImplementedException();
        }
    }
}
