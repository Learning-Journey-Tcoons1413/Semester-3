using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A
{
    internal class Book : Media , IEncryptable
    {
        public string Author { get; }
        public string Summary { get; }

        public Book(string title, int year, string author, string summary) : base(title, year)
        { 
            Author = author;
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
            return $"Book Title: {Title} ({Year}) \nAuthor: {Author} \n--------------------";
        }

    }
}
