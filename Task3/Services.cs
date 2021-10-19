using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Services
    {
        public static int Cost(List<Obligation> derivative)
        {
            int cost = 0;
            foreach (Obligation o in derivative)
            {
                cost += o.GetPrice;
            }
            return cost;
        }
        public static Obligation SearchOblig(List<Obligation> derivative, DateTime date, string insurer, string client, Risk risk, int price)
        {
            foreach (Obligation o in derivative)
            {
                if (o.GetDate.Equals(date) && o.GetInsurer.Equals(insurer) && o.GetClient.Equals(client)
                    && o.GetRisk.Equals(risk) && o.GetPrice == price)
                {
                    return o;
                }

            }

            return null;
        }
    }
}
