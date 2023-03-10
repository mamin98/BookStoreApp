using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Store.Models
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        
        [ForeignKey("Orders")]
        public int OrderId { get; set; }
        public Order Orders { get; set; } = new Order();


        [ForeignKey("Books")]
        public int BookId { get; set; }
        public Book Books { get; set; } = new Book();
    }
}
