//======================================================== 
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
    internal class Order
    {
        private int id;

        private DateTime timeReceived;

        private DateTime? timeFufilled;

        private List<IceCream> iceCreamList;

        static private int totalCount;

        public int Id { get; set; }
        public DateTime TimeReceived { get; set; }
        public DateTime? TimeFulfilled { get; set; }
        public List<IceCream> IceCreamList { get; set; }
        public static int TotalCount { get; set; }
        
        public Order()
        {
            IceCreamList = new List<IceCream>();
        }

        public Order(int id, DateTime timeReceived)
        {
            Id = id;
            TimeReceived = timeReceived;
        }

        public void ModifyIceCream(int index, IceCream iceCream) //**
        {
            if (index >= 0 && index < IceCreamList.Count)
            {
                IceCreamList[index] = iceCream;
            }
        }

        public void AddIceCream(IceCream iceCream)
        {
            IceCreamList.Add(iceCream);
        }

        public void DeleteIceCream(int index)
        {
            if (IceCreamList.Count > 1)
            {
                IceCreamList.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Cannot have zero ice creams in an order.");
            }
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (var iceCream in IceCreamList)
            {
                total += iceCream.CalculatePrice();
            }
            return total;
        }

        public override string ToString()
        {
            return $"Order ID: {Id}, Time Received: {TimeReceived}, Time Fulfilled: {TimeFulfilled}, Total: {CalculateTotal()}";
        }
    }
}
