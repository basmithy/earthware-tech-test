namespace EarthwareTechTest.Helpers
{
    public class TaxCalculator
    {
        public double GetSalesTax(double originalPrice)
        {
            return Math.Round(originalPrice * 0.1, 2);
        }

        public double GetImportDutyTax(double originalPrice)
        {
            return Math.Ceiling(Math.Round(originalPrice * 0.05, 2) * 20) / 20;
        }
    }
}
