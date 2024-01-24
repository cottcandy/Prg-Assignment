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
    class Flavour
    {
        private string type;

        private bool premium;

        private int quantity;
        public string Type { get; set; }
        public bool Premium { get; set; }
        public int Quantity { get; set; }

        public Flavour() { }
        public Flavour(string type, bool premium, int quantity)
        {
            Type = type;
            Premium = premium;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Flavour Type: {Type}, Premium Flavour: {Premium}, Quantity: {Quantity}";
        }
    }
}
