using System.ComponentModel.DataAnnotations;

namespace ShopingApp.Api.Data.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(180)]
        public string? Image { get; set; }
        public decimal Price { get; set; }

        [Required, MaxLength(25)]
        public string Unit { get; set; }

        public short CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }

}
