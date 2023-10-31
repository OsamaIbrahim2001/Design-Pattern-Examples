using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStatePattern.Core.States
{
    internal class DeliverState : IOrderState
    {
        private readonly Order order;
        public DeliverState(Order order)
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
            order.State = new ReturnState(order);
        }

        public void Ship()
        {
            throw new NotImplementedException();
        }
    }
}
