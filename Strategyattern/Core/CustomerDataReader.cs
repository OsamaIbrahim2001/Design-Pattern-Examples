namespace Strategyattern.Core
{
    public class CustomerDataReader
    {
        public IEnumerable<Customer> GetCustomers()
        {
            return new[] {
            new Customer{Id=1, Name="Osama",CustomerCategory=CustomerCategory.Gold},
            new Customer{Id=2,Name="Mohamed",CustomerCategory = CustomerCategory.Silver},
            new Customer{Id=3,Name="Ali",CustomerCategory = CustomerCategory.New}
            };
        }
    }
}
