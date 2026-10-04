using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace Lab5_OOP_Arv
{
    internal class GoldenRetriever : Dog
    {

        public bool Loyal { get; set; }

        public GoldenRetriever(string name,int age, double weight, string gender, bool wildanimal, bool happy, bool loyal) : base (name, age, weight, gender, wildanimal, happy)
        {
            Loyal = loyal;
        }

        public bool isLoyal()
        {
            if (Loyal == true)
            {
                Console.WriteLine($"Hunden {Name} är väldigt lojal mot dig");
                return true;
            }
            else
            {
                Console.WriteLine($"Hunden {Name} är inte lojal mot dig");
                return false;
            }
       
    }
        public override void makeSound()
        {
            Console.WriteLine($"Hunden {Name} säger Wuff Wuff!");
        }


    }
}
