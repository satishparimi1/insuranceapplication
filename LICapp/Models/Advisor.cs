using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICapp.Models
{
    public class Advisor
    {
        //Fields: Id, First Name, Last Name, Address, Phone Number, Health Status (Green or Red)
        public int Id { get; set; }
        public string First_Name { get; set; }
        //public string Name { get; set; }
        public string Last_Name { get; set; }
        public string Address { get; set; }
        public string Phone_Number { get; set; }
    }
}
