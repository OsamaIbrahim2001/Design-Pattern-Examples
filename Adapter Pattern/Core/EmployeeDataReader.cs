namespace Adapter_Pattern.Core
{
    public class EmployeeDataReader
    {
        public IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee
                {
                    FirstName = "Osama",
                    MediumName="Ibrahim",
                    LastName="Sadek",
                    PayItems = new List<PayItem>()
                    {
                        new PayItem { Name = "Basic Salary", Value = 1000 },
                        new PayItem { Name = "Transportation", Value = 250 },
                        new PayItem { Name = "Medical Insurance", Value = 150,IsDeduction=true }
                    }
                },
                  new Employee
                {
                    FirstName = "Mohamed",
                    MediumName="Ibrahim",
                    LastName="Sadek",
                    PayItems = new List<PayItem>()
                    {
                        new PayItem { Name = "Basic Salary", Value = 1000 },
                        new PayItem { Name = "Transportation", Value = 250 },
                        new PayItem { Name = "Medical Insurance", Value = -150 }
                    }
                }
            };
        }
    }
}
