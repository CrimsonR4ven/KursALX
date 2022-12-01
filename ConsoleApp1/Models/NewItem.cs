namespace ShopApp.Models
{
    public class NewItem
    {
        public string Product;
        public decimal Price;
        public int HowMuch;

        public NewItem(string product, decimal price, int howMuch)
        {
            Product = product;
            Price = price;
            HowMuch = howMuch;
        }
    }
}
