using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Obligation : IComparable<Obligation>
    {
        private DateTime Date;
        private string Insurer;
        private string Client;
        private Risk Risk;
        private int Price;

        public Obligation(DateTime date, string insurer, string client, Risk risk, int price)
        {
            Date = date;
            Insurer = insurer;
            Client = client;
            Risk = risk;
            Price = price;
        }

        public DateTime GetDate { get => Date; }
        public string GetInsurer { get => Insurer; }
        public string GetClient { get => Client; }
        public int GetPrice { get => Price; }
        internal Risk GetRisk { get => Risk; }

        public int CompareTo(Obligation other)
        {

            return (int)GetRisk - (int)other.GetRisk;
        }

        public override String ToString()
        {
            return "Date: " + GetDate + " Insurer: " + GetInsurer + " Client: "
                + GetClient + " Risk: " + GetRisk + " Price: " + GetPrice;
        }
    }
    }
