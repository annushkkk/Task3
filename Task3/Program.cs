using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            var derivative = CreateDerivative();

            Console.WriteLine("Cost of derivative:" + Services.Cost(derivative));
            Console.WriteLine("Found obligation: " + Services.SearchOblig(derivative, DateTime.Parse("17.12.2020"), "I3", "C3", Risk.Risk3, 300));
            Console.WriteLine("Derivates befor sorting by risk");
            foreach (Obligation o in derivative)
            {
                Console.WriteLine(o);
            }
            derivative.Sort();
            Console.WriteLine("Derivates after sorting by risk");
            foreach (Obligation o in derivative)
            {
                Console.WriteLine(o);
            }

        }
        static List<Obligation> CreateDerivative()
        {
            Obligation obligation1 = new Obligation(DateTime.Now, "I1", "C1", Risk.Risk1, 100);
            Obligation obligation2 = new Obligation(DateTime.Parse("30.7.2021"), "I2", "C2", Risk.Risk2, 200);
            Obligation obligation3 = new Obligation(DateTime.Parse("17.12.2020"), "I3", "C3", Risk.Risk3, 300);
            Obligation obligation4 = new Obligation(DateTime.Parse("10.3.2021"), "I4", "C4", Risk.Risk4, 400);
            List<Obligation> derivative = new List<Obligation>
            {
                obligation1, obligation3, obligation2, obligation4
            };
            return derivative;
        }
    }
}
