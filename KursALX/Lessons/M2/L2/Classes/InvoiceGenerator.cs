using KursALX.Lessons.M2.L2.Interfaces;

namespace KursALX.Lessons.M2.L2.Classes
{
    public class InvoiceGenerator : IInvoiceGenerator
    {
        public Invoice GenerateInvoice()
        {
            return new Invoice();
        }
    }
}
