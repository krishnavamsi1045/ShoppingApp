namespace ShoppingApp.Models
{
    public class product
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public short CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

}
