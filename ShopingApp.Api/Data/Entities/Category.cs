using System.ComponentModel.DataAnnotations;

namespace ShopingApp.Api.Data.Entities
{
    public class Category
    {
        [Key]
        public short Id { get; set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }

        [Required, MaxLength(150)]
        public string Image { get; set; }

        public short ParentId { get; set; }
    }

}
