using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes
{
    class Client : Person
    {
        public int Client_Id { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
    }
}
