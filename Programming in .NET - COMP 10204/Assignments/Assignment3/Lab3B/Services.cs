using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// I, Thomas Coons, 000317961 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
// Date: November 2nd 2024
namespace Lab3B
{
    /// <summary>
    /// Service Class
    /// </summary>
    public class Service
    {
        public string Type { get; }
        public int Price { get; }

        /// <summary>
        /// Service Constructor
        /// </summary>
        /// <param name="type">Service type</param>
        /// <param name="price">Service Price</param>
        public Service(string type, int price)
        { 
            Type = type;
            Price = price;
        }
        public override string ToString()
        {
            return Type;
        }
    }
}
