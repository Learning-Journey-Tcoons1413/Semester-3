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
    /// The Movie Class
    /// </summary>
    internal class Movie : Media, IEncryptable
    {
        public string Director { get; }
        public string Summary { get; }

        /// <summary>
        /// Movie Constructor
        /// </summary>
        /// <param name="title">Title of movie</param>
        /// <param name="year">Year of movie</param>
        /// <param name="director">Director of movie</param>
        /// <param name="summary">Summary of movie</param>
        public Movie (string title, int year, string director, string summary) : base(title,year)
        {
            Director = director;
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
        /// <returns>String representation of the movie with Title, Year, and Director</returns>
        public override string ToString()
        {
            return $"Movie Title: {Title} ({Year}) \nDirector: {Director} \n--------------------";
        }
    }
}
