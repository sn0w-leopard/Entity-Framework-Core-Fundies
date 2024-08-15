using Entity_Framework_Core_Fundies.Models;
using Entity_Framework_Core_Fundies.Data;
using System.Diagnostics;

using PizzaDbContext context = new PizzaDbContext();

var fluentProducts = context.Products
    .Where(p => p.Price > 10.00M)
    .OrderBy(p => p.Name);

Console.WriteLine("Fluent API Query");
Console.WriteLine(new string('-', 20));

foreach (Product product in fluentProducts)
{
    Console.WriteLine($"Id: {product.Id}");
    Console.WriteLine($"Name: {product.Name}");
    Console.WriteLine($"Price: {product.Price}");
    Console.WriteLine(new string('-', 20));
}


var veggieSpecial = context.Products
    .Where(p => p.Name == "Veggie Special Pizza")
    .FirstOrDefault();

if ( veggieSpecial is Product )
{
    context.Remove( veggieSpecial );
}

context.SaveChanges();

var linkProducts = from product in context.Products
                   where product.Price > 10.00M
                   orderby product.Name
                   select product;

Console.WriteLine("Link Query");
Console.WriteLine(new string('-', 20));

foreach (Product product in linkProducts)
{
    Console.WriteLine($"Id: {product.Id}");
    Console.WriteLine($"Name: {product.Name}");
    Console.WriteLine($"Price: {product.Price}");
    Console.WriteLine(new string('-', 20));
}

