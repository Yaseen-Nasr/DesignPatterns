namespace StrategyPattern.Core
{
    internal class ItemDataReader
    {
        public IEnumerable<Item> GetItems()
        {
            return new[]
            {
                new Item() {Id= 1, UnitPrice = 10000, Name="Laptop"},
                new Item() {Id=2, UnitPrice = 2000, Name="LCD"},
                new Item() {Id= 3, UnitPrice = 150, Name="Keybord"},
                new Item() {Id= 4, UnitPrice = 100, Name="Maouse"}
            };
        }
    }
}
