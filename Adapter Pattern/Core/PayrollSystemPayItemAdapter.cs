
namespace Adapter_Pattern.Core
{
    public class PayrollSystemPayItemAdapter
    {
        private readonly PayItem payItem;
        public PayrollSystemPayItemAdapter(PayItem payItem)
        {
            this.payItem = payItem;
        }
        public string Name => payItem.Name;
        public decimal Value => payItem.IsDeduction ? payItem.Value * -1 : payItem.Value;
    }
}
