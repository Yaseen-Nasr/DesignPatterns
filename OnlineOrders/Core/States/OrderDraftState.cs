namespace OnlineOrders.Core.States
{
    internal class OrderDraftState : IOrderState
    {
        private readonly Order _order;
        public OrderDraftState(Order order)
        {
            _order = order;
        }
        //order only can move from draft to confirmed
        public void Confirm()
        {
            //Validation or transation logic 
            _order.State = new OrderConfirmState(_order);
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
            
            throw new NotImplementedException();

        }
    }
}
