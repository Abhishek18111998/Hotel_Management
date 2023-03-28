namespace Hotel_Management.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public Gender genger { get; set; }
        public int UserAge { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public Role role { get; set; }
        public  Address address {get;set;}

        //List<Booking> bookings {get;set;}
    }
}
