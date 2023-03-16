using Book_Store.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Book_Store.Models
{
    public class BookStoreContext: IdentityDbContext<AppUser> //DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Types> Types { get; set; }


        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) { }

        // create composite primary key for OrderItem table
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrderItem>()
                .HasKey(k => new { k.OrderId, k.BookId});

            // seed dummy data
            modelBuilder.Seed();

            // seed dummy data for Identity Roles
            modelBuilder.SeedRoles();
        }
    }
}
