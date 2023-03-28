namespace Hotel_Management.Model
{
    public class Address
    {
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
    }
}
