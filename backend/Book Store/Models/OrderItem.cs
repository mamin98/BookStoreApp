using System.ComponentModel.DataAnnotations.Schema;

namespace Book_Store.Models
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        
        [ForeignKey("Orders")]
        public int OrederId { get; set; }
        public Orders Orders { get; set; } = new Orders();


        [ForeignKey("Books")]
        public int BookId { get; set; }
        public Books Books { get; set; } = new Books();
    }
}
