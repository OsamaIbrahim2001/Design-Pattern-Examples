using SalesSystemPaymentAbstraction_FactoryPattern_;
using Strategyattern;
using Strategyattern.Core;
using Strategyattern.Core.DiscountStrategy;
using Strategyattern.Core.Payment;
using Strategyattern.Core.ShoppingCart;
using System;

var customerReader =new CustomerDataReader();
var customers = customerReader.GetCustomers();

var itemReader = new ItemDataReader();
var items = itemReader.GetItems();

while (true)
{

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Customer List : ");
    Console.ForegroundColor = ConsoleColor.White;
    foreach (var customer in customers)
    {
        Console.WriteLine($"\t{customer.Id}. {customer.Name} ({customer.CustomerCategory})");
    }

    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Items List : ");
    Console.ForegroundColor = ConsoleColor.White;
    foreach (var item in items)
    {
        Console.WriteLine($"\t{item.Id}. {item.Name} ({item.UnitPrice:0.00})");
    }

    Console.Write("Enter Customer ID : ");
    var customerId = int.Parse(Console.ReadLine());
    Console.Write("Select shopping cart type (Online | Instore) : ");
    ShoppingCart shoppingCart = Console.ReadLine().Equals("Online", StringComparison.OrdinalIgnoreCase) ? new OnlineShoppingCart() : new InStoreShoppingCart();
    while (true)

    {
        Console.Write("Enter Item ID (0 to Complete the order) : ");
        int itemId = int.Parse(Console.ReadLine());

        if (itemId == 0)
            break;

        Console.Write("Enter Item Quantity : ");
        int quantity = int.Parse(Console.ReadLine());

        var item = items.First(i => i.Id == itemId);
        shoppingCart.AddItem(itemId, quantity, item.UnitPrice);



        //ICustomerDiscountStrategy customerDiscountStrategy = new CustomerDiscountStrategyFactory().CreateCustomerDiscountStrategyFactory(customer.CustomerCategory);
        //var invoiceManager=new InvoiceManager();
        //invoiceManager.SetDiscountStrategy(customerDiscountStrategy);
        //var invoice = invoiceManager.CreateInvoice(customer, quantity,unitPrice);

        // Console.WriteLine($"Invoice creared for customer {customer.Name} with totlal = {invoice.NetPrice}");

    }
    var selectedCustomer = customers.First(x => x.Id == customerId);
    Console.Write("Select Payment Methode (Visa | Paypal) : ");
    ProcessorPayment paymentProcessr = Console.ReadLine().Equals("Visa", StringComparison.OrdinalIgnoreCase) ? new VisaPaymentProcessor() : new PaypalPaymentProcessor();

    shoppingCart.Checkout(selectedCustomer,paymentProcessr);
    Console.WriteLine("Press any key to create another invoice");
    Console.ReadLine();
    Console.WriteLine("------------------------");
}