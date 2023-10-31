using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Core.Commands
{
    internal class AddStockCommand : ICommand
    {
        private readonly Product product;
        private readonly int quatity;

        public AddStockCommand(Product product,int quatity)
        {
            this.product = product;
            this.quatity = quatity;
        }
        public void Execute()
        {
            product.AddStock(quatity);
        }
    }
}
