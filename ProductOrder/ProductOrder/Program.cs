using ProductOrder.Entities;
using System;
using System.Globalization;

namespace ProductOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, orderStatus, client);

            Console.Write("How many items to this order? ");
            int quantityItens = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantityItens; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, price);
                OrderItem orderItem = new OrderItem(productQuantity, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
