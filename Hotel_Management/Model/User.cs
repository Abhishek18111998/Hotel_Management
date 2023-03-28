namespace Hotel_Management.Model
{
    public class User
    {
        public int ClientId { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        // public Gender genger { get; set; }
        public int ClientAge { get; set; }
        public string ClientPhoneNumber { get; set; }
        public string ClientEmail { get; set; }
        public string ClientPassword { get; set; }
        // public Role role { get; set; }

        //public  Address address {get;set;}

        //List<Booking> bookings {get;set;}
    }
}
