//========================================================
// Student Number : S10258514
// Student Name : Zhang Lixin
// Partner Name : Borra Sri Venkata Surya Nanditha  
//========================================================

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_Assignment
{
    class Cone : IceCream
    {
        private bool dipped;
        public bool Dipped { get; set; }

        public Cone() { }
        public Cone(string option, int scoops, List<Flavour> flavours, List<Topping> toppings, bool dipped) : base(option, scoops, flavours, toppings)
        {
            Dipped = dipped;
        }

        public override double CalculatePrice()
        {
            double price;
            if (Scoops == 1)
            {
                price = 4;
            }
            else if (Scoops == 2)
            {
                price = 5.5;
            }
            else
            {
                price = 6.5;
            }

            // Chocolate-dipped
            if (Dipped) price += 2;

            // Premium flavour
            price += Flavours.Where(f => f.Premium).Sum(f => f.Quantity * 2);

            // Toppings
            price += Toppings.Count();
            return price;
        }
        public override string ToString()
        {
            return $"Cone Ice Cream Total Price: {CalculatePrice}";
        }
    }
}
