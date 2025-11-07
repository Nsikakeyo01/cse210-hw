// Author: Nsikak Eyo
// Location: Uyo, Akwa Ibom State, Nigeria
// Main program for Online Ordering Program (Foundation #2)

using System;
using NsikakOrdering;

namespace NsikakOrderingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create addresses
            CustomerAddress addr1 = new CustomerAddress("23 Unity Street", "Uyo", "Akwa Ibom", "Nigeria");
            CustomerAddress addr2 = new CustomerAddress("100 Maple Avenue", "Springfield", "IL", "USA");

            // Create customers
            Customer customer1 = new Customer("Nsikak Eyo", addr1);
            Customer customer2 = new Customer("Jane Doe", addr2);

            // Create orders
            Order order1 = new Order(customer1);
            Order order2 = new Order(customer2);

            // Add products
            order1.AddProduct(new Product("Laptop", "LAP001", 700, 1));
            order1.AddProduct(new Product("Wireless Mouse", "MOU101", 20, 2));

            order2.AddProduct(new Product("Keyboard", "KEY202", 40, 1));
            order2.AddProduct(new Product("USB Hub", "USB303", 15, 3));

            // Store orders
            Order[] orders = { order1, order2 };

            // Display details
            foreach (var order in orders)
            {
                Console.WriteLine("\n---------------------------");
                Console.WriteLine(order.PackingLabel());
                Console.WriteLine(order.ShippingLabel());
                Console.WriteLine($"💰 Total Cost: ${order.TotalPrice():0.00}");
            }
        }
    }
}
