namespace OrderStatePattern.Core.States
{
    internal interface IOrderState
    {
        void Cancel();
        void Drift();
        void Confirm();
        void Process();
        void Ship();
        void Deliver();
        void Return();
    }
}
