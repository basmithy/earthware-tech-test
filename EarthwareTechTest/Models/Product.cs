namespace EarthwareTechTest.Models
{
    public class Product
    {
        public int Amount { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public bool IsImported { get; set; }
        public bool IsTaxExempt { get; set; }
    }
}
