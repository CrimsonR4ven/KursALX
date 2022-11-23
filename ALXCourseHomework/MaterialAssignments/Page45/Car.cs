namespace ALXCourseHomework.MaterialAssignments.Page45
{
    public class Car
    {
        public string Brand;
        public double NettoPrice;
        public double InventoryPrice;
        public double Tax;
        public Car(string brand, double nettoPrice, double inventoryPrice, double tax)
        {
            Brand = brand;
            NettoPrice = nettoPrice;
            InventoryPrice = inventoryPrice;
            Tax = tax;
        }
        public double CarBruttoPrice()
        {
            return (NettoPrice * (1 + Tax)) + InventoryPrice;
        }
        public void Present()
        {
            Console.WriteLine($"Car brand: {Brand}");
            Console.WriteLine($"Car netto price: {NettoPrice}");
            Console.WriteLine($"Car inventory price: {InventoryPrice}");
            Console.WriteLine($"Tax: {NettoPrice * Tax}");
        }
    }
}
