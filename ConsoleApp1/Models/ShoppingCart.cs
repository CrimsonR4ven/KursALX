namespace ShopApp.Models
{
    public class ShoppingCart
    {
        public List<NewItem?> Cart;

        public ShoppingCart()
        {
            Cart = new List<NewItem?>();
        }

        public decimal GetPrice()
        {
            return Cart.Sum(x => (x.Price*x.HowMuch));
        }

        public void ClearCart()
        {
            Cart.Clear();
        }
    }
}
