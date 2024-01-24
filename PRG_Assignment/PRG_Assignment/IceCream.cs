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
    abstract class IceCream
    {
        private string option;

        private int scoops;

        private List<Flavour> flavours;

        private List<Topping> toppings;

        public string Option { get; set; }
        public int Scoops { get; set; }
        public List<Flavour> Flavours { get; set; }
        public List<Topping> Toppings { get; set; }

        public IceCream() { }
        public IceCream(string option, int scoops, List<Flavour> flavours, List<Topping> toppings)
        {
            Option = option;
            Scoops = scoops;
            Flavours = flavours;
            Toppings = toppings;
        }

        public abstract double CalculatePrice();

        public override string ToString()
        {
            return $"Option: {Option}, Scoops: {Scoops}, Flavours: {string.Join(", ", Flavours)}, Toppings: {string.Join(", ", Toppings)}";
        }
    }
}
