using System;

class Program
{
    static void Main(string[] args)
    {
        Order _order1 = new Order();
        _order1.CustomerAttributes("charley", "120 w", "rexburg", "Idaho", "USA");
        _order1.AddProduct("shampoo", "5342", 5.42, 100);
        _order1.AddProduct("butter", "r467", 6.43, 5);
        Console.WriteLine(_order1.ShippingLabel());
        Console.WriteLine(_order1.PackingLabel());
        Console.WriteLine($"Total Price: ${_order1.CalculateTotalCost()}");
        
        Console.WriteLine();
        Console.WriteLine();

        Order _order2 = new Order();
        _order2.CustomerAttributes("winston", "120 w", "Calgary", "Alberta", "CAN");
        _order2.AddProduct("shampoo", "5342", 5.42, 100);
        _order2.AddProduct("butter", "r467", 6.43, 5);
        Console.WriteLine(_order2.ShippingLabel());
        Console.WriteLine(_order2.PackingLabel());
        Console.WriteLine($"Total Price: ${_order2.CalculateTotalCost()}"); 
    }
}