namespace AdapterPattern_Payroll_System_.Core
{
    public class Employee
    {
        public string FullName { get; set; }
        public IEnumerable<PayItem> PayItems { get; set; }
    }
}
