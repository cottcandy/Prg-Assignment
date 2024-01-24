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
    class PointCard
    {
        private int points;

        private int punchCard;

        private string tier;

        public int Points { get; set; }
        public int PunchCard { get; set; }
        public string Tier { get; set; }

        public PointCard() { }
        public PointCard(int points, int punchCard)
        {
            Points = points;
            PunchCard = punchCard;
            Tier = "Ordinary";
        }

        public void AddPoints(int points) //**
        {
            Points += points;
        }

        public void RedeemPoints(int points) //**
        {

            Points -= points;
        }

        public void Punch()
        {
            int PunchCardCount = 0;
            if (PunchCardCount == 11)
            {
                PunchCardCount = 0;
            }
            PunchCardCount++;
        }

        public override string ToString()
        {
            return $"PointCard Variable:\nPoints: {Points}\nPunchCard: {PunchCard}\nTier: {Tier}\n";
        }
    }
}
