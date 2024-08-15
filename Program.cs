using Entity_Framework_Core_Fundies.Models;
using Entity_Framework_Core_Fundies.Data;
using System.Diagnostics;

using PizzaDbContext context = new PizzaDbContext();

Product veggieSpecial = new Product()
{
    Name = "Veggie Special Pizza",
    Price = 9.99M
};
context.Products.Add(veggieSpecial);

Product deluxeMeat = new Product()
{
    Name = "Deluxe Meat Pizza",
    Price = 12.99M
};
context.Add(deluxeMeat);

context.SaveChanges();

