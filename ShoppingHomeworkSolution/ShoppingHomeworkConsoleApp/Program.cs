using System;
using ProductsLibrary;
using ShoppingCartLibrary;
using OrderLibrary;

class Program
{
    static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart();

        while (true)
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Add a product to the cart");
            Console.WriteLine("2. Place an order");
            Console.WriteLine("3. Exit");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":

                    Console.Write("Enter the product name: ");
                    string productName = Console.ReadLine();
                    Console.Write("Enter the product price: ");
                    if (double.TryParse(Console.ReadLine(), out double productPrice))
                    {
                        Product product = new Product
                        {
                            ProductsName = productName,
                            ProductsPrice = productPrice
                        };
                        cart.AddToCart(product);
                        Console.WriteLine($"Product added to the cart: Name: {productName}, Price: {productPrice:C}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid price format.");
                    }
                    break;

                case "2":
                    if (cart.GetItemCount() > 0)
                    {
                        OrderService orderService = new OrderService();
                        int orderNumber = orderService.PlaceOrder(cart);
                        Console.WriteLine($"Order with number {orderNumber} placed.");
                        cart.ClearCart();
                    }
                    else
                    {
                        Console.WriteLine("The cart is empty. An order cannot be placed.");
                    }
                    break;

                case "3":

                    return;

                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }
        }
    }
}
