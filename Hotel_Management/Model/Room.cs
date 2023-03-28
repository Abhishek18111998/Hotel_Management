using System;
using System.Collections.Generic;

namespace Hotel_Management.Model
{
    public class Room
    {
        public int RoomID { get; set; }
        public RoomType RoomType { get; set; }
        public bool HasBalcony { get; set; }
        public string RoomDescription { get; set; }
        public decimal RoomPrice { get; set; }
        public int MaxNumberofPerson { get; set; }
        public List<Booking> Bookings { get; set; } 
    }
}
