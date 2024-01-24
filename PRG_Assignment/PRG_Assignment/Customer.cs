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
    class Customer
    {
        private string name;

        private int memberId;

        private DateTime dob;

        private Order currentOrder;

        private List<Order> orderHistory;

        private PointCard rewards;

        public string Name { get; set; }
        public int MemberId { get; set; }
        public DateTime Dob { get; set; }
        public Order CurrentOrder { get; set; }
        public List<Order> OrderHistory { get; set; }
        public PointCard Rewards { get; set; }

        public Customer() { }
        public Customer(string name, int memberId, DateTime dob)
        {
            Name = name;
            MemberId = memberId;
            Dob = dob;

            CurrentOrder = new();
            OrderHistory = new();
            Rewards = new();
        }

        public Order MakeOrder()
        {
            if (OrderHistory.Count == 0)
            {
                Order order1 = new Order(Order.TotalCount + 1, DateTime.Now); CurrentOrder = order1;
                Order.TotalCount++;
            }
            else
            {
                Order order1 = new Order(Order.TotalCount + 1, DateTime.Now); CurrentOrder = order1;
                Order.TotalCount++;
            }
            OrderHistory.Add(CurrentOrder); return CurrentOrder;
        }

        public bool IsBirthday()
        {
            DateTime now = DateTime.Now;
            if (now.Month == Dob.Month && now.Day == Dob.Day)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Customer Name: {Name}\nMemberID: {MemberId}\nDOB: {Dob}\nCurrent Order: {CurrentOrder}\nOrder History: {OrderHistory}\nRewards: {Rewards}";
        }
    }
}
