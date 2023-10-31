using CommandPattern.Core;
using CommandPattern.Core.Commands;
using System.Xml.Linq;

var laptop = new Product(1, "Laptop", 2000, 10);
var keyboard = new Product(2, "Keyboard", 300, 50);
var mouse = new Product(3, "Mouse", 150, 70);

while (true)
{
    Order order = new();
    var invoker = new CommandInvoker();
    while (true)
    {
        Console.WriteLine("Select one of the below commands : ");
        Console.WriteLine("\t1. Add Laptop");
        Console.WriteLine("\t2. Add Keyboard");
        Console.WriteLine("\t3. Add Mouse");
        Console.WriteLine("\t0. Process & Exit");

        int commandId = int.Parse(Console.ReadLine());
        Product selectedProduct = null;

        if (commandId == 1)
        {
            invoker.AddCommand(new AddProductCommand(order, laptop, 1));
            invoker.AddCommand(new AddStockCommand(laptop, -1));
        }
        else if (commandId == 2)
        {
            invoker.AddCommand(new AddProductCommand(order, keyboard, 1));
            invoker.AddCommand(new AddStockCommand(keyboard, -1));
        }
        else if (commandId == 3)
        {
            invoker.AddCommand(new AddProductCommand(order, mouse, 1));
            invoker.AddCommand(new AddStockCommand(mouse, -1));
        }
        else if (commandId == 0)
        {
            invoker.ExecudCommands();
            var totalQuantity = order.Lines.Sum(x => x.Quantity);
            var totalPrice = order.Lines.Sum(x => x.UnitPrice);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Order #{order.Id} created: Quantity = {totalQuantity}, Total Price = {totalPrice}");
            Console.ForegroundColor = ConsoleColor.White;
            break;
        }
       
    }
    Console.WriteLine("-------------------");
}