namespace OnlineOrders.Core.States
{
    internal class OrderShippState : IOrderState
    {
        private readonly Order _order;
        public OrderShippState(Order order)
        {
            _order = order;
        }
        public void Confirm()
        {
            throw new NotImplementedException();

        }
        public void Cancel()
        {
            throw new NotImplementedException();

        }
        public void Process()
        {
            throw new NotImplementedException();

        }
        public void Shipp()
        {
            throw new NotImplementedException();

        }
        public void Deliver()
        {
            throw new NotImplementedException();

        }
        public void Return()
        {
            _order.State = new OrderReturnState(_order);
        }
    }
}
