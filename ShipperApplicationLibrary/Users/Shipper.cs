using System;
using System.Collections.Generic;
using System.Text;
using ShipperApplicationLibrary.Users;

namespace ShipperApplicationLibrary.Users
{
    public class Shipper : User
    {
        public User sh = new User();
        public string username;
        private string Pword;
        public string UserName { get; set; }
        private string Password { get; set; }
        public void Sighnup()
        {
            Console.WriteLine("enter the username");
            username = Console.ReadLine();
            Console.WriteLine("Enter the password");
            password = Console.ReadLine();
            Console.WriteLine("Enter email id");
            emailid = Console.ReadLine();
        }
    }
}
