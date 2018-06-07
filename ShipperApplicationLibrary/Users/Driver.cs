using System;
using System.Collections.Generic;
using System.Text;
using ShipperApplicationLibrary.Users;

namespace ShipperApplicationLibrary.Users
{
    public class Driver : User
    {
        public string username;
        private string pword;
        public string idproof;
        public string vehicletype;
        public string UserName { get; set; }
        private string Password { get; set; }
        public void Sighnup()
        {
            Console.WriteLine("enter the username");
            username = Console.ReadLine();
            Console.WriteLine("Enter the password");
            password = Console.ReadLine();
            Console.WriteLine("Provide the idproof");
            idproof = Console.ReadLine();
            Console.WriteLine("Provide vehicle type");
            vehicletype = Console.ReadLine();
        }
    }
}
