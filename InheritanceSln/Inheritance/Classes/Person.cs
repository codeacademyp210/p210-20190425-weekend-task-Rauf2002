using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public int Card_Id { get; set; }

        public static int Id { get; set; }
        public int GetId(int paramId)
        {
            paramId = Id;
            return Id++;
        }
    }

}

