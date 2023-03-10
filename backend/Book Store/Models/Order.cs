using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Store.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal TotalPrice { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = new Customer();

        public List<OrderItem> Books { get; set; } = new List<OrderItem>();
    }
}
