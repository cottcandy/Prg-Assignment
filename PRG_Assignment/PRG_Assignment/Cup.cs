//========================================================
// Student Number : S10258514
// Student Name : Zhang Lixin
// Partner Name : Borra Sri Venkata Surya Nanditha  
//========================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_Assignment
{
    class Cup : IceCream
    {
        public Cup() { }
        public Cup(string option, int scoops, List<Flavour> flavours, List<Topping> toppings) : base(option, scoops, flavours, toppings) { }

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

            // Premium flavour
            price += Flavours.Where(f => f.Premium).Sum(f => f.Quantity * 2);

            // Toppings
            price += Toppings.Count();
            return price;
        }

        public override string ToString()
        {
            return $"Cup Ice Cream Total Price: {CalculatePrice}";
        }
    }
}
