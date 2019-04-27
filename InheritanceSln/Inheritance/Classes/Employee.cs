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
        public class StaticId
        {
            public static int Id;

            public void count()
            {
                Id++;
            }
            public int getNum()
            {
                return Id;
            }

        }
        public StaticId newId = new StaticId();

        //public DateTime birthDay = Convert.ToDateTime(Console.ReadLine());

    }
}
