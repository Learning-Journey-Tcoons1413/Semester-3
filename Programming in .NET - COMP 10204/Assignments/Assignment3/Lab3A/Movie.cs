using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    internal class Movie : Media, IEncryptable
    {
        public string Director { get; }
        public string Summary { get; }

        public Movie (string title, int year, string director, string summary) : base(title,year)
        {
            Director = director;
            Summary = summary;
        }
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

        public string Encrypt()
        {
            return Decrypt();
        }
        public override string ToString()
        {
            return $"Movie Title: {Title} ({Year}) \nDirector: {Director} \n--------------------";
        }
    }
}
