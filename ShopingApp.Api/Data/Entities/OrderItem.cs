﻿using System.ComponentModel.DataAnnotations;

namespace ShopingApp.Api.Data.Entities
{
    public class OrderItem
    {
        [Key]
        public Guid Id { get; set; }
        public long OrderId { get; set; }
        public int ProductId { get; set; }

        [Required, MaxLength(100)]
        public string ProductName { get; set; }

        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal Amount { get; set; }

        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }

}
