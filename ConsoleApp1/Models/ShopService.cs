using System.Diagnostics;

namespace ShopApp.Models
{
    public class ShopService
    {
        ShoppingCart cart;
        string? GoOn;

        public ShopService()
        {
           cart = new ShoppingCart();
        }

        public void Run()
        {
            while(GoOn != "end")
            {
                AddToCart(CreateProduct());
                Console.WriteLine("write end to show final price");
                GoOn = Console.ReadLine();
                Console.Clear();
            }
            Present();
        }

        private NewItem? CreateProduct()
        {
            Console.WriteLine("What is the name of the product?");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("What is the price of the product? (use , instead of .)");
            Console.Write("Price: ");
            try
            {
                Decimal price = Decimal.Parse(Console.ReadLine());
                Console.Write("\nAmount of that product: ");
                int howMuch = int.Parse(Console.ReadLine());
                return new NewItem(name, price, howMuch);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("You Used . not , :<");
                return new NewItem("Nope", 0, 0);
            }
        }

        private void AddToCart(NewItem item)
        {
            cart.Cart.Add(item);
        }

        private void Present()
        {
            Console.WriteLine("--------------Your-Shopping-Cart--------------");
            foreach (var item in cart.Cart)
            {
                if(item.HowMuch != 0)
                Console.WriteLine($"Name: {item.Product} Price: {item.Price}");
            }
            Console.WriteLine($"Full Price: {cart.GetPrice()}");
        }
    }
}
