using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// I, Thomas Coons, 000317961 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
// Date: November 2nd 2024
namespace Lab3A
{

    /// <summary>
    /// The Book Class
    /// </summary>
    internal class Book : Media , IEncryptable
    {
        public string Author { get; }
        public string Summary { get; }

        /// <summary>
        /// Book Constructor
        /// </summary>
        /// <param name="title">Title of book</param>
        /// <param name="year">Year of book</param>
        /// <param name="author">Author of book</param>
        /// <param name="summary">Summary of book</param>
        public Book(string title, int year, string author, string summary) : base(title, year)
        { 
            Author = author;
            Summary = summary;
        }

        /// <summary>
        /// Decrypts the summary
        /// </summary>
        /// <returns>Decrypted summary</returns>
        public string Decrypt()
        {
            string decypted = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string encrypted = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm";
            string summary = "";
            for (int i = 0; i < Summary.Length; i++)
            {
                int tempIndex = encrypted.IndexOf(Summary[i]);

                if (tempIndex != -1)
                    summary += decypted[tempIndex];
                else
                    summary += Summary[i];
            }

            return summary;
        }

        /// <summary>
        /// Encrypts the summary
        /// </summary>
        /// <returns>Encrypted summar</returns>
        public string Encrypt()
        {
            return Decrypt();
        }

        /// <summary>
        /// Overrided ToString
        /// </summary>
        /// <returns>String representation of the book with Title, Year, and Author</returns>
        public override string ToString()
        {
            return $"Book Title: {Title} ({Year}) \nAuthor: {Author} \n--------------------";
        }

    }
}
