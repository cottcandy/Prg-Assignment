//======================================================== **
// Student Number : S10258514
// Student Name : Borra Sri Venkata Surya Nanditha 
// Partner Name : Zhang Lixin 
//========================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_Assignment
{
    class Topping
    {
        private string type;
        public string Type { get; set; }

        public Topping() { }
        public Topping(string type)
        {
            Type = type;
        }

        public override string ToString()
        {
            return $"Topping Type: {Type}";
        }
    }
}
