namespace Book_Store.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string UserName { get; set; } 
        public string Password { get; set; } 
        public string Email { get; set; } 
        public string PhoneNumber { get; set; }  
        public string Address { get; set; }
        public string? Image { get; set; }
        public byte? UploadImg { get; set; }

        public List<Order> Orders { get; set; } 


    }
}
