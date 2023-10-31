using OrderStatePattern.Core.States;

namespace OrderStatePattern.Core
{
    internal class Order
    {
        public Order() {
            State = new DriftState(this);
        }
        public List<OrderLine> Lines { get; set; } = new();
        public IOrderState State { get; set; }

        public void Draft()=>State.Drift();
        public void Confirm()=>State.Confirm();
        public void Cancel() => State.Cancel();
        public void UnderProcess()=> State.Process();
        public void Ship()=>State.Ship();
        public void Deliver()=>State.Deliver();
        public void Return()=>State.Return();
    }
}
