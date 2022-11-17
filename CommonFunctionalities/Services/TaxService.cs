namespace CommonFunctionalities.Services
{
    public class TaxService
    {
        private const double VatPercentage = 0.23;
        private const double GovernmentPercentage = 0.17;
        public double CalculateTax(double income)
        {
            var vatTax = CalculateVat(income);
            double tax = CalculateGovernmentTax(income, vatTax) + vatTax;
            
            return tax;
        }

        private double CalculateVat(double income)
        {
            return income * VatPercentage;
        }

        private double CalculateGovernmentTax(double income, double vatTax)
        {
            return (income - vatTax) * GovernmentPercentage;
        }
    }
}
