

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

    
    while (true)

    {
        Console.Write("Enter Item ID (0 to Complete the order) : ");
        int itemId = int.Parse(Console.ReadLine());

        if (itemId == 0)
            break;

        Console.Write("Enter Item Quantity : ");
        int quantity = int.Parse(Console.ReadLine());

        var product = productss.First(i => i.Id == itemId);

    }
    
    Console.WriteLine("Press any key to create another invoice");
    Console.ReadLine();
    Console.WriteLine("------------------------");
}