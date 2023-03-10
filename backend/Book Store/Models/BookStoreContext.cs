using Microsoft.EntityFrameworkCore;

namespace Book_Store.Models
{
    public class BookStoreContext: DbContext
    {
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Types> Types { get; set; }


        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) { }

        // create composite primary key for OrderItem table
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrderItem>()
                .HasKey(k => new { k.OrederId, k.BookId});

        }
    }
}
