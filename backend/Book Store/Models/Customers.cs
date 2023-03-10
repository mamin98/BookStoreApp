namespace Book_Store.Models
{
    public class Customers
    {
        public int ID { get; set; }
        public string UserName { get; set; } = "";
        public string Password { get; set; } = "";
        public string Email { get; set; } = "";
        public string PhoneNumber { get; set; } = ""; 
        public string Address { get; set; } = "";
        public List<Orders> Orders { get; set; } = new List<Orders>();


    }
}
