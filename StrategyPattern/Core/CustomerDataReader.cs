namespace StrategyPattern.Core
{
    internal class CustomerDataReader
    {
        public IEnumerable<Customer> GetCustomers()
        {
            return new[]
            {
                new Customer()
                {
                      Id=1,
                      Name="Mohamed Ahmed",
                      CustomerCategory=CustomerCategory.Gold

                },
                new Customer()
                {
                      Id=2,
                      Name="Ibrahim Mohamed ",
                      CustomerCategory=CustomerCategory.Silver  
                }
                ,

                new Customer()
                {
                      Id=3,
                      Name="Sameh Mohamed ", 

                }
            };
        }
    }
}
