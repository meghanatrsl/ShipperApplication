using System;
using System.Collections.Generic;
using System.Text;

namespace ShipperApplicationLibrary.Users
{
    public class User
    {
        protected string name;
        protected string emailid;
        protected int mobile_number;
        protected string password;
        public string Name { get; set; }
        public string EmailID { get; set; }
        public int Mobile_Number { get; set; }
        public void Login() { }
        public void Signup() { }
       
    }
}
