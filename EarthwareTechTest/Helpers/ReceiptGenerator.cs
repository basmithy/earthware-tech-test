using EarthwareTechTest.Models;

namespace EarthwareTechTest.Helpers
{
    public class ReceiptGenerator
    {
        public TaxCalculator taxCalculator = new();

        public Receipt Receipt { get; set; } = new();

        public Receipt GenerateReceipt(List<Product> shoppingBasket)
        {
            foreach (var item in shoppingBasket)
            {
                double originalPrice = item.Price;

                if (!item.IsTaxExempt)
                {
                    item.Price += taxCalculator.GetSalesTax(originalPrice);
                }

                if (item.IsImported)
                {
                    item.Price += taxCalculator.GetImportDutyTax(originalPrice);
                }

                item.Price = Math.Round(item.Price, 2);

                Receipt.TotalSalesTax += item.Price - originalPrice;
                Receipt.TotalPrice += item.Price;
            }

            Receipt.TotalSalesTax = Math.Round(Receipt.TotalSalesTax, 2);
            Receipt.TotalPrice = Math.Round(Receipt.TotalPrice, 2);
            Receipt.Products = shoppingBasket;

            return Receipt;
        }
    }
}
