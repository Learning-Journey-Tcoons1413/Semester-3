using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFormAppStart
{
    // REMEMBER from OOP a Guest is a Person 
    class Guest : Person  // In Java we say Guest extends Person (C# -> : means extends)
    {
        private DateTime checkIn; // Backing Variable for property
        public DateTime CheckIn 
        { get
            {
                return checkIn;
            }
            set
            {
                if (value < DateTime.Today)
                {
                    throw new ArgumentException("Check in date must be greater than today");
                }
                checkIn = value;
            }
        }

        public DateTime CheckOut { get; }

        public Room Room { get; }
        public Guest(string firstName, string lastName, DateTime checkInDate, DateTime checkOutDate, Room room) : 
               base(firstName, lastName)  // This is like super - must occur before { base similar to super 
        {

            if (checkInDate >= checkOutDate)
                throw new ArgumentException("Check In date must be before Check Out date");
            // Keep our own copies of dates 
            CheckIn = checkInDate;
            CheckOut = checkOutDate;
            Room = room;
        }
        public override string ToString()
        {
            // like super.toString in java
            return base.ToString() + $" [From {CheckIn:D} to {CheckOut:D}]"; 
        }

        public bool IsInHotel(DateTime d)
        {
            return d >= CheckIn && d <= CheckOut;
        }
    }
}
