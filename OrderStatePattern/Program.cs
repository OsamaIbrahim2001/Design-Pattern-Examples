

using OrderStatePattern.Core;

var productReader = new ProductDataReader();
var productss = productReader.GetItems();

while (true)
{

   

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Product List : ");
    Console.ForegroundColor = ConsoleColor.White;
    foreach (var item in productss)
    {
        Console.WriteLine($"\t{item.Id}. {item.Name} ({item.UnitPrice:0.00})");
    }

    var order=new Order();
    Console.WriteLine($"Order State : {order.State}");
    while (true)
    {
        Console.Write("Enter Product ID (0 to Complete the order) : ");
        int productId = int.Parse(Console.ReadLine());

        if (productId == 0)
            break;

        Console.Write("Enter Item Quantity : ");
        int quantity = int.Parse(Console.ReadLine());

        var product = productss.First(i => i.Id == productId);
        order.Lines.Add(new OrderLine { ProductId = productId, Quantity = quantity, UnitPreice = product.UnitPrice });

    }

    while (true)
    {
        Console.ForegroundColor= ConsoleColor.Blue;
        Console.WriteLine("Select Action : ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\t1. Confirm");
        Console.WriteLine("\t2. Process");
        Console.WriteLine("\t3. Cancel");
        Console.WriteLine("\t4. Ship");
        Console.WriteLine("\t5. Delivery");
        Console.WriteLine("\t6. Return");

        int action = int.Parse(Console.ReadLine());
        try
        
        {
            if (action == 0)
                break;
            else if (action == 1)
                order.Confirm();
            else if (action == 2)
                order.UnderProcess();
            else if (action == 3)
                order.Cancel();
            else if (action == 4)
                order.Ship();
            else if (action == 5)
                order.Deliver();
            else if (action == 6)
                order.Return();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Order State Changed to : {order.State}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    Console.WriteLine("------------------------");
}