﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDesktop.Classes
{
    internal class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get {
                return ((FirstName + " " + MiddleName).Trim() + " " + LastName).Trim();
            } }
    }
}
