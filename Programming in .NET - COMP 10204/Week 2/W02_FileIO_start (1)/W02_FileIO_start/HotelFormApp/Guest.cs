using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleFileApp;

namespace HotelFormApp
{
    // REMEMBER from OOP a Guest is a Person 
    class Guest : Person  // In Java we say Guest extends Person (C# -> : means extends)
    {
        private DateTime checkIn;
        public DateTime GetCheckIn() { return checkIn; }
        private DateTime checkOut;
        public DateTime GetCheckOut() { return checkOut; }
        public Guest(string firstName, string lastName, DateTime checkInDate, DateTime checkOutDate) :
               base(firstName, lastName)  // This is like super - must occur before { base similar to super 
        { 
            if (checkInDate >= checkOutDate)
                throw new ArgumentException("Check In date must be before Check Out date");
            // Keep our own copies of dates 
            checkIn = new DateTime(checkInDate.Year, checkInDate.Month, checkInDate.Day);
            checkOut = new DateTime(checkOutDate.Year, checkOutDate.Month, checkOutDate.Day);
        }
        public override string ToString()
        {
            // like super.toString in java
            return base.ToString() + $" [From {checkIn:D} to {checkOut:D}]";
        }

        public bool IsInHotel(DateTime d)
        {
            return d >= checkIn && d <= checkOut;
        }
    }
}
