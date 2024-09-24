using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFormAppStart
{
    class Room
    {
        public string RoomNumber { get;  }
        public List<DateTime> Occupied { get; }

        public Room(string name)
        {
            if (room == "")
            {
                throw new ArgumentException("BAD");
            }
            RoomNumber = room;

        }
    }
}
