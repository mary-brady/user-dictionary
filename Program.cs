using System;
using System.Collections.Generic;
using userlibrary.Models;

namespace userlibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, User> users = new Dictionary<string, User>(){
            {"mark", new User("mark", "IHeartCode")},
            {"jake", new User("jake", "MarkRocks")}
            };

            Console.Clear();
            Console.WriteLine("Please login to continue");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            if (users.ContainsKey(username) && users[username].ValidatePassword(password))
            {
                Console.WriteLine("Success!!");
            }
            else
            {
                Console.WriteLine("Invalid username or password!");
            }
        }
    }
}
