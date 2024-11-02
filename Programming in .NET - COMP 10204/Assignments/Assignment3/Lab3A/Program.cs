using System;
using System.Diagnostics.Eventing.Reader;
using System.IO;
// I, Thomas Coons, 000317961 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
// Date: November 2nd 2024
namespace Lab3A
{
    /// <summary>
    /// The main class that handles user input and output.
    /// </summary>
    internal class Program
    {
        //Const variable for text file
        const string DATA = "Data.txt";

        /// <summary>
        /// Main method of the main class. Handles user input and output.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string userInput = "";
            try
            {
                Media[] mediaData = ReadData();
                //Menu();
                //Console.Write("Enter Choice: ");
                

                while (userInput != "6")
                {
                    Console.Write("\x1b[2J"); // This helps with clearing the buffer on the Console so the information displays correctly. Source: https://github.com/dotnet/runtime/issues/28355
                    Console.Write("\x1b[3J"); // This helps with clearing the buffer on the Console so the information displays correctly. Source: https://github.com/dotnet/runtime/issues/28355
                    Menu();
                    Console.Write("Enter Choice: ");
                    userInput = Console.ReadLine();
                    while (!int.TryParse(userInput, out int input) || int.Parse(userInput) > 6 || int.Parse(userInput) < 1)
                    {
                        Console.Clear();
                        Menu();
                        Console.Write("Invalid Option. Try Again: ");
                        userInput = Console.ReadLine();

                    }
                   
                    switch (userInput)
                    {

                        case "1":
                            PrintData(mediaData,userInput);
                            break;
                        case "2":
                            PrintData(mediaData, userInput);
                            break;
                        case "3":
                            PrintData(mediaData, userInput);
                            break;
                        case "4":
                            PrintData(mediaData, userInput);
                            break;
                        case "5":
                            Console.Write("Enter a search string: ");
                            userInput = Console.ReadLine();
                            PrintSearchedData(mediaData,userInput);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }


        }

        /// <summary>
        /// Reads the 'Data.txt' file and forms a list of Media objects.
        /// </summary>
        /// <returns>A list of Media objects</returns>
        /// <exception cref="ArgumentException">Exception thrown due to insufficient file size</exception>
        public static Media[] ReadData()
        {

            StreamReader file = new StreamReader(DATA);
            string[] data = file.ReadToEnd().Trim().Split(new[] { "-----" }, StringSplitOptions.RemoveEmptyEntries); // Source: https://learn.microsoft.com/en-us/dotnet/api/system.stringsplitoptions?view=net-8.0

            if (data.Length == 0 || data.Length > 100)
                throw new ArgumentException("Insufficient file size.");

            Media[] media = new Media[data.Length];
            int count = 0;
            string[] temp;

            while (count < data.Length)
            {
                temp = data[count].Trim().Split(new[] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries); // Source: https://learn.microsoft.com/en-us/dotnet/api/system.stringsplitoptions?view=net-8.0

                string tempString = "";

                for (int i = 0; i < temp.Length; i++)
                {
                    if (i == 1)
                        tempString += $"|{temp[i]}";
                    else
                    {
                        tempString += temp[i];
                    }
                }
                string[] tempArray = tempString.Split('|');

                switch (tempArray[0])
                {
                    case "BOOK":
                        media[count] = new Book(tempArray[1], int.Parse(tempArray[2]), tempArray[3], tempArray[4]);
                        break;
                    case "MOVIE":
                        media[count] = new Movie(tempArray[1], int.Parse(tempArray[2]), tempArray[3], tempArray[4]);
                        break;
                    case "SONG":
                        media[count] = new Song(tempArray[1], int.Parse(tempArray[2]), tempArray[3], tempArray[4]);
                        break;
                    default:
                        break;

                }
                count++;
            }

            return media;

        }

        /// <summary>
        /// Simple method to display a recurring menu.
        /// </summary>
        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tom's Media Collection");
            Console.WriteLine("======================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. List All Books");
            Console.WriteLine("2. List All Movies");
            Console.WriteLine("3. List All Songs");
            Console.WriteLine("4. List All Media");
            Console.WriteLine("5. Search All Media by Title");
            Console.WriteLine();
            Console.WriteLine("6. Exit");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;

        }

        /// <summary>
        /// Prints the specified data based on user input.
        /// </summary>
        /// <param name="mediaChoice">The list of Media objects to filter through</param>
        /// <param name="input">User's choice</param>
        public static void PrintData(Media[] mediaChoice, string input)
        {
            Console.Clear();
            foreach (var m in mediaChoice)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                if (input == "1")
                {
                    if (m is Book book)
                    {
                        Console.WriteLine(book);
                        Console.WriteLine("");
                    }
                }
                else if (input == "2")
                {
                    if (m is Movie movie)
                    {
                        Console.WriteLine(movie);
                        Console.WriteLine("");
                    }
                }
                else if (input == "3")
                {
                    if (m is Song song)
                    {
                        Console.WriteLine(song);
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Console.WriteLine(m);
                    Console.WriteLine("");
                }
            }
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Prints the specified searched data based on user input.
        /// </summary>
        /// <param name="mediaSearch">The list of Media objects to filter through</param>
        /// <param name="search">User's search criteria</param>
        public static void PrintSearchedData(Media[] mediaSearch, string search)
        {
            string summary = "";
            Console.Clear();
            
            foreach (Media m in mediaSearch)
            { 
                bool found = m.Search(search);
                if (found)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(m);
                    Console.ForegroundColor = ConsoleColor.White;
                    if (m is Book book)
                    {
                        Console.WriteLine();
                        summary = book.Decrypt();
                        Console.WriteLine(summary);
                        Console.WriteLine();

                    }
                    else if (m is Movie movie)
                    {
                        Console.WriteLine();
                        summary = movie.Decrypt();
                        Console.WriteLine(summary);
                        Console.WriteLine();
                    }
                    else if (m is Song song)
                    {
                        Console.WriteLine();
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
