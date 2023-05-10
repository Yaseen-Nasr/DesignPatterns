using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineOrders.Core.States;

namespace OnlineOrders.Core
{
    internal class Order
    {
        public Order()
        {
            State = new OrderDraftState(this);
        }
        public List<OrderLine> Lines { get; set; } = new();
        //public OrderState State { get; private set; }
        public IOrderState State { get; internal set; }
        //public void SetOrderState(OrderState state)
        //{
        //    State = state;
        //}

        public void Confirm()
        {
            State.Confirm();
        }
        public void Cancel()
        {
            State.Cancel();
        }
        public void Process()
        {
            State.Process();
        }
        public void Deliver()
        {
            State.Deliver();
        }
        public void Shipp()
        {
            State.Shipp();
        }
        public void Return()
        {
            State.Return();
        }
    }


}
