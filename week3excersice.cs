

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3day3exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                var db = new week3exerciseEntities();
                var productOrders = db.ProductOrders;

                //4 a.View all records

                foreach (var productOrder in productOrders)
                {
                    Console.WriteLine($"{productOrder.Product.Id} {productOrder.Product.ProductName} {productOrder.Id} {productOrder.ProductId} {productOrder.OrderId} {productOrder.Product.Category} {productOrder.Product.Cost} {productOrder.Order.Id} {productOrder.Order.Date.ToShortDateString()}");
                }

                //4.b.Add a new record

                var toAddProduct = new Product
                {
                    ProductName = "Added Product",
                    Category = "Added Category",
                    Cost = 23.01M
                };           
                var toAddOrder = new Order
                {
                    Date = DateTime.Now
                };
                var toAddProductOrder = new ProductOrder
                {
                    ProductId = 3,
                    OrderId = 3
                };
                db.Products.Add(toAddProduct);  
                db.Orders.Add(toAddOrder)  ;
                db.ProductOrders.Add(toAddProductOrder);
                db.SaveChanges();

                //4 c.Delete a record of a given ID value

                var toDeleteProductOrder = db.ProductOrders.Find(1);
                db.ProductOrders.Remove(toDeleteProductOrder);
                db.SaveChanges();

                //4 d.Update a record

                var toUpdateProduct = db.Products.Find(1);
                toUpdateProduct.Category = "Updated Category";
                db.SaveChanges();             
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An exeption was raised. Error message: {ex.Message}");
            }
                      
            Console.ReadLine();
        }

        //5. Create a function that takes an order number and returns the total cost of that order.

        private static void TotalCosts(int orderNumber)
        {
            var db = new week3exerciseEntities();
            try
            {
                decimal totalCosts = db.ProductOrders.Where(z => z.OrderId == orderNumber).Sum(z => z.Product.Cost);
                Console.WriteLine($"Total costs of Order {orderNumber}: {totalCosts}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Order Id {orderNumber} is invalid or has no corresponding products. Error message: {ex.Message}");
            }
        }

        // 6. Create a function that takes a product id and returns the details of all order that contains the product.

        private static void OrderDetails(int prodId)
        {
            var db = new week3exerciseEntities();
            var orders = db.ProductOrders.Where(z => z.ProductId == prodId).Select(z => z.Order);
            if (orders.Count() != 0)
            {
                Console.WriteLine($"Order Details for Product {prodId}");
                Console.WriteLine("Id Date");
                foreach (var order in orders)
                {
                    Console.WriteLine($"{order.Id}  {order.Date.ToShortDateString()}");
                }
            }
            else
            {
                Console.WriteLine($"No Orders for Product {prodId}");
            }
        }
    }
}
