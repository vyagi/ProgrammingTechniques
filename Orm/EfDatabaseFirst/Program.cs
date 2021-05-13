using System;
using System.Linq;
using EfDatabaseFirst;
using Microsoft.EntityFrameworkCore;

using var context = new AdventureWorksContext();

// foreach (var product in context.Products.Include(x=>x.ProductCategory))
// {
//     Console.WriteLine($"{product.Name} of category {product.ProductCategory.Name}");
// }

// foreach (var customer in context.Customers)
// {
//     Console.WriteLine($"{customer.LastName} {customer.FirstName}");
// }

// Console.WriteLine(context.Customers.Count());

