namespace OnlineOrders.Core.States
{
    internal class OrderProcessState : IOrderState
    {
        private readonly Order _order;
        public OrderProcessState(Order order)
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
            _order.State = new OrderShippState(_order);

        }
        public void Deliver()
        {
            throw new NotImplementedException();

        }
        public void Return()
        {
            throw new NotImplementedException();

        }
    }
}
