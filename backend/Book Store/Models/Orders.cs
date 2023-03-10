using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Store.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal TotalPrice { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customers Customer { get; set; } = new Customers();

        public List<OrderItem> Books { get; set; } = new List<OrderItem>();
    }
}
