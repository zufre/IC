using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new AdventureWorksLT2017Entities();
            var customers = db.Customers.Take(20);
            var firstNames = db.Customers.Select(z => z.FirstName).ToList();
            

            //foreach(var customer in customers)
          //  {
            //    Console.WriteLine($"{customer.CustomerID} {customer.FirstName} {customer.LastName}");
           // }


            var blackProducts = db.Products.Where(z => z.Color == "Black").ToList();

            var totalCosts = db.Products
                .Where(z => z.Color == "Black")
                .Select(z => z.StandardCost).Sum();
            var Product680 = db.Products.Find(680);
            Product680.StandardCost = 1000;
            db.SaveChanges();

            var customers20 = db.Customers.SqlQuery("SELECT * FROM SalesLT.Customer").Take(20).ToList();

            //var toRemove = db.SalesOrderHeaders.Find(71780);
           // db.SalesOrderHeaders.Remove(toRemove);
           // db.SaveChanges();

            var addresses = db.CustomerAddresses.Take(20);
            foreach(var address in addresses)
            {
                Console.WriteLine($"{address.AddressID} {address.AddressType} {address.Customer.FirstName} {address.Customer.LastName}");
            }

           // var customer = new Customer
           // {
           //     NameStyle = true,
            //    Title = "Mr.",
            //    FirstName = "Cedric",
            //    LastName = "David",
            //    MiddleName = string.Empty,

           //     Suffix = string.Empty,
            //    CompanyName = string.Empty,
            //    SalesPerson = string.Empty,
            //    EmailAddress = "ceds@gmail.com",
            //    Phone ="04555345",
            //    PasswordHash = string.Empty,
            //    PasswordSalt = string.Empty,
             //   ModifiedDate = DateTime.Now
//

           // };

            //db.Customers.Add(customer);
            //db.SaveChanges();

            var ced = db.Customers.Find(30119);
            ced.Phone = "999999999";
            db.SaveChanges();
            Console.WriteLine(ced.FirstName);
            db.Customers.Remove(ced);
            db.SaveChanges();
            //foreach (var blackProduct in blackProducts)
            //{              
            //    Console.WriteLine(blackProduct.Name);
            //}
            //foreach (var c in customers20)
            //{
            //    Console.WriteLine(c.FirstName);
            //}
           //Console.WriteLine(totalCosts);
           // Console.WriteLine(Product680.Name); ;


           Console.ReadLine();
        }
    }
}
