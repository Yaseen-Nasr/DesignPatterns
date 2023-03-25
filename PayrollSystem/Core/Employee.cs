namespace PayrollSystem.Core
{
    public class Employee
    {
        public string FullName { get; set; } = null!;
        public IEnumerable<PayItem> PayItems { get; set; }
    }

}
