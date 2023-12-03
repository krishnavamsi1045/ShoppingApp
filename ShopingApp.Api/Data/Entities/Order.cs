﻿using System.ComponentModel.DataAnnotations;

namespace ShopingApp.Api.Data.Entities
{
    public class Order
    {
        [Key]
        public long Id { get; set; }

        public int UserId { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
        public decimal TotalAmount { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Placed;
        public virtual ICollection<OrderItem> OrderItems { get; set; }

    }

}
