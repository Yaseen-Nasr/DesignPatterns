namespace OnlineOrders.Core.States
{
    internal interface IOrderState
    {

        void Confirm();
        void Cancel();
        void Process();

        void Shipp();

        void Deliver();
        void Return();

    }
}
