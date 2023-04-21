namespace StrategyPattern.Core
{
    internal class Invoice
    {
        public Customer Customer { get; set; }
        public IEnumerable<InvoiceLine> Lines { get; set; }
        public double TotalPrice => Lines.Sum(x => x.Quantity * x.UnitPrice);
        public double DiscountPrecentage{ get; set; }
        public double Taxes { get; set; }  
        public double NetPrice => TotalPrice + Taxes - TotalPrice * DiscountPrecentage ;
    }
}
