namespace EarthwareTechTest.Models
{
    public class Receipt
    {
        public List<Product> Products { get; set; } = new();

        public double TotalSalesTax { get; set; }
        public double TotalPrice { get; set; }
    }
}
