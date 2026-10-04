using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lab5_OOP_Arv
{
    internal class Bear : Animal
    {
        public double Tall { get; set; }

        public Bear(string name, int age, double weight, string gender, bool wildanimal, double tall) : base(name, age, weight, gender, wildanimal)
        {
            Tall = tall;
        }


        public void howTall()
        {
            Console.WriteLine($"Björnen {Name}'s längd är: {Tall} meter och {Name}'s vikt är: {Weight} kg");
        }

        public override void makeSound()
        {
            Console.WriteLine($"Björnen {Name} gör ett grovt rytande!");
        }
    }
}
