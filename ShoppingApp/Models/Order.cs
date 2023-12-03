using ShoppingApp.Enumeration;

namespace ShoppingApp.Models
{
    public class Order
    {
        public long ID { get; set; }
        public IEnumerable<CartItem> Items { get; set; } = Enumerable.Empty<CartItem>();
        public DateTime Date { get; set; }= DateTime.Now;
        public decimal TotalAmount => Items.Sum(i => i.Amount);

       

        public OrderStatus Status { get; set; }

        private static readonly IReadOnlyDictionary<OrderStatus, Color> _OrderStatusColorMap = new Dictionary<OrderStatus, Color>
        {

            [OrderStatus.Placed] = Colors.Yellow,
            [OrderStatus.Confiremd] = Colors.Blue,
            [OrderStatus.Delivered] = Colors.Green,
            [OrderStatus.Confiremd] = Colors.Red,

        };
    }
}
