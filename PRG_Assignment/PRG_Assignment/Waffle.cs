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
using static System.Formats.Asn1.AsnWriter;

namespace PRG_Assignment
{
    class Waffle : IceCream
    {
        private string waffleFlavour;
        public string WaffleFlavour { get; set; }

        public Waffle() { }
        public Waffle(string option, int scoops, List<Flavour> flavours, List<Topping> toppings, string waffleFlavour) : base(option, scoops, flavours, toppings)
        {
            WaffleFlavour = waffleFlavour;
        }

        public override double CalculatePrice()
        {
            double price;
            if (Scoops == 1)
            {
                price = 7;
            }
            else if (Scoops == 2)
            {
                price = 8.5;
            }
            else
            {
                price = 9.5;
            }

            // Waffle Flavour
            if (WaffleFlavour != "Original") price += 3;

            // Premium Flavours
            price += Flavours.Where(f => f.Premium).Sum(f => f.Quantity * 2); // code to check for flavours premium/normal and check prices

            // Toppings
            price += Toppings.Count();
            return price;

        }

        public override string ToString()
        {
            return $"Waffle Ice Cream Total Price: {CalculatePrice}";
        }
    }
}
