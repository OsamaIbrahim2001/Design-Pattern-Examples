
namespace Adapter_Pattern.Core
{
    public class PayrollSystemEmployeeAdapter
    {
        private readonly Employee employee;
        private readonly IEnumerable<PayrollSystemPayItemAdapter> payItems;
        public PayrollSystemEmployeeAdapter(Employee employee)
        {
            this.employee = employee;
            payItems=employee.PayItems.Select(payItem=>new PayrollSystemPayItemAdapter(payItem)).ToList(); 
        }
        public string FullName => employee.FullName;
        public IEnumerable<PayrollSystemPayItemAdapter> PayItems => payItems;
        
    }
}
