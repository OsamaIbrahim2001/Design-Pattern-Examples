using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStatePattern.Core.States
{
    internal class ConfirmState : IOrderState
    {
        private readonly Order order;
        public ConfirmState(Order order)
        {
            this.order = order;
        }
        public void Cancel()
        {
            order.State = new CancelState(order);
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
            order.State = new PeocessState(order);
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
