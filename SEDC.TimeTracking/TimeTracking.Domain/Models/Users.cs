﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracking.Domain.Models
{
    public class Users : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public override void GetInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Welcome {FirstName} {LastName}");
            Console.ResetColor();
        }
    }
}
