namespace KursALX.Lessons.M2.L2.Classes
{
    public class Invoice
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public double BruttoAmount { get; set; }
        public double NettoAmount { get; set; }
        public int NIP { get; set; }

        public void PresentInvoice()
        {
            Console.WriteLine($"[Invoice] id: {Id}");
            Console.WriteLine($"Customer name: {CustomerName}");
            Console.WriteLine($"NIP: {NIP}");
            Console.WriteLine($"Income (Brutto): {BruttoAmount}");
            Console.WriteLine($"Income (Netto): {NettoAmount}");
        }
    }
}
