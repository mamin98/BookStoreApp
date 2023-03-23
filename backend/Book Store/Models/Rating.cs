namespace Book_Store.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        private int _stars;
        public int Stars
        {
            get => _stars;
            set
            {
                if (value < 1 || value > 5) throw new ArgumentException("ratings should be within 1-5 range");
                _stars = value;
            }
        }

        public string? Review { get; set; } = null!;

        public int BookId { get; set; }
        public Book Book { get; set; } = null!;
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
    }
}
