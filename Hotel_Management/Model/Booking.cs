using Microsoft.AspNetCore.Server.HttpSys;
using System;


namespace Hotel_Management.Model
{
    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }   
        public int NumberofPerson { get; set; }
        public decimal TotalPrice { get; set; }
        public int ClientId { get; set; }
        public User User { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }


    }
}
