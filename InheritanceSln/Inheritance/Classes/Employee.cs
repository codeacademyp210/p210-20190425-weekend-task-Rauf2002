using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes
{
    class Employee : Person
    {
        public string Position { get; set; }
        public int Salary { get; set; }
    

        //public DateTime birthDay = Convert.ToDateTime(Console.ReadLine());

    }
}
