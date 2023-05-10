namespace OnlineOrders.Core
{
    internal class ProdectDataReder 
    {
        public IEnumerable<Product> GetProducts ()
        {
            return
                new[]
                {
                    new Product{Id=1,Name="LapTop",UnitPrice=10000},
                    new Product{Id=1,Name="LCD",UnitPrice=2000},
                    new Product{Id=1,Name="keyboard",UnitPrice=150},
                    new Product{Id=1,Name="Mouse",UnitPrice=100}
                };
        }
    }


}
