using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_StringsFiles
{
   
    /// <summary>
    /// A Class to model a product - marked as serializable
    /// </summary>
    [Serializable]
    class Product
    {
        public int Number { get; }
        public string Title { get; }
        public string Type { get; }
        private decimal unitprice;  // Backing variable for the property 
        public decimal UnitPrice
        {
            get { return unitprice; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Product: price must be greater than 0");
                unitprice = value;
            }
        }
        private int unitsSold;   // BACKING variable for the property
        public int UnitsSold
        {
            get { return unitsSold; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Product: price must be greater than 0");
                unitsSold = value;
            }
        }

        public Product(int number, string title, string description, decimal price, int quantity)
        {
            if (number <= 0)
                throw new ArgumentException("Product: Number must be greater than 0");
            Number = number;
            Title = title;
            Type = description;
            UnitPrice = price;       // Will call setter
            UnitsSold = quantity;    // Will call setter
        }

        public decimal ProductValue()
        {
            return UnitsSold * UnitPrice;
        }

        public override string ToString()
        {
            return $"{Number,-4} {Title,-30} {Type,-12} ${UnitPrice:F2}  {UnitsSold}";
        }
        public string ToShortString()
        {
            return $"{Title} - {Type}";
        }
        /// <summary>
        /// Convert a product to a comma delemited string - may want to override in other classes 
        /// </summary>
        /// <returns></returns>
        public virtual string ToCsv()
        {
            return $"{Number},{Title},{Type},{UnitPrice},{UnitsSold}";
        }
    }
}
