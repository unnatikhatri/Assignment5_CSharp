using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> PrimeMinister = new Dictionary<int, string>();

            //inserting details into the dictionary
            PrimeMinister.Add(1998, "Atal Bihari Vajpayee");
            PrimeMinister.Add(2014, "Narendra Modi");
            PrimeMinister.Add(2004, "Dr.Manmohan Singh");


            //output the prime minister at the year 2004
            Console.WriteLine("Prime Minister in 2004 : {0}\n", PrimeMinister[2004]);

            //adding the current PrimeMinister into the list
            PrimeMinister.Add(2019, "Narendra Modi");


            //sorted list of prime minister by year
            Console.WriteLine("Sorted List :\n");
            foreach (KeyValuePair<int, string> prime_minister in PrimeMinister.OrderBy(x => x.Value))
            {
                Console.WriteLine("{0} {1}", prime_minister.Key, prime_minister.Value);
            }
        }
    }
}
