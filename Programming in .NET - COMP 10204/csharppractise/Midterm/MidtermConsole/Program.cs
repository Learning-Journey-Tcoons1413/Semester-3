using System;
using System.Collections.Generic;
using System.IO;

namespace MidtermConsole
{
    internal class Program
    {
        static StreamReader file = new StreamReader("people.txt");
        static List<User> users = new List<User>();
        static int invalid = 0;
        static void Main(string[] args)
        {
            Read();
            Menu();
            string input = "";

            try
            {
                while (!input.ToLower().Equals("e"))
                {
                    Console.Write("Select a user ('0' to exit): ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int success))
                    {
                        int choice = int.Parse(input);
                        User user = users[choice - 1];
                        Console.WriteLine(user);
                        Console.Write("1. Check Password | 2. Set Password: ");
                        input = Console.ReadLine();
                        if (int.TryParse(input, out int successful))
                        {
                            choice = int.Parse(input);
                            switch (choice)
                            { 
                                case 1:
                                    Console.Write("Password: ");
                                    string password = Console.ReadLine();
                                    if (user.checkPassword(password))
                                    {
                                        Console.WriteLine(user.Password);
                                        Console.Write("Password verified. Any key to continue.");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Menu();
                                    }
                                    else
                                    {
                                        Console.Write("Incorrect Password. Any key to continue.");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Menu();
                                    }
                                    break;
                                case 2:
                                    Console.Write("Change Password: ");
                                    password = Console.ReadLine();
                                    if (user.setPassword(password))
                                    {
                                        Console.WriteLine(user.Password);
                                        Console.Write("Password changed. Any key to continue.");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Menu();
                                    }
                                    else
                                    {
                                        Console.Write("Password not long enough. Any key to continue.");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Menu();
                                    }
                                    break;
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid option.");
                    }
                }
            }
            catch (ArgumentException ex) { Console.WriteLine(ex.Message); }


        }

        public static void Read()
        {

            while (!file.EndOfStream)
            {
                try
                {
                    string[] person = file.ReadLine().Split(',');
                    User user = new User(person[0], int.Parse(person[1]), person[2].Trim());
                    users.Add(user);
                }
                catch (Exception ex) { invalid++; }
            }
        }

        public static void Menu()
        {
            Console.WriteLine($"{"Name",-20} {"Access",-20}");
            int count = 0;
            foreach (var user in users)
            {
                count++;
                Console.WriteLine($"{count}) {user.Name,-20} {user.Access,-20}");
            }
            Console.WriteLine();
            Console.WriteLine($"Invalid users found: {invalid}");
        }
    }
}
