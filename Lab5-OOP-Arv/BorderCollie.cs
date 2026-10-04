using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace Lab5_OOP_Arv
{
    internal class BorderCollie : Dog
    {
       public double Fast { get; set; }
       public BorderCollie(string name, int age, double weight, string gender, bool wildanimal, bool happy, double fast) : base(name, age, weight, gender, wildanimal, happy)
        {
            Fast = fast;
        }

        public void runFast()
        {
            Console.WriteLine($"Hunden {Name} springer i {Fast}km/h");
        }

        public override void makeSound()
        {
            Console.WriteLine($"Hunden {Name} säger Waff Waff!");
        }


    
    }
}
