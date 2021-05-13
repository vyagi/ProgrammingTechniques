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

// var customer = context.Customers.Single(x=>x.CustomerId == 2);
// Console.WriteLine($"{customer.LastName} {customer.FirstName} {customer.CompanyName}");
//
// customer.CompanyName = "University of Information Technology and Management";
//
// Console.WriteLine($"{customer.LastName} {customer.FirstName} {customer.CompanyName}");
//
// context.SaveChanges(); 

// var newAddress = new Address();
// newAddress.AddressLine1 = "Sucharskiego 2";
// newAddress.City = "Rzeszów";
// newAddress.CountryRegion = "Podkarpackie";
// newAddress.StateProvince = "Podkarpackie";
// newAddress.PostalCode = "35-330";
// context.Addresses.Add(newAddress);
//
// context.SaveChanges();

var addressToDelete = context.Addresses.First(x=>x.City=="Rzeszów");
context.Addresses.Remove(addressToDelete);

context.SaveChanges();