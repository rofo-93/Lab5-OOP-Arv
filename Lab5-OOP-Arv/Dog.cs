using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_OOP_Arv
{
    internal class Dog : Animal
    {

        public bool Happy { get; set; }

        public Dog(string name, int age, double weight, string gender, bool wildanimal, bool happy) : base(name, age, weight, gender, wildanimal)
        {
            Happy = happy;
        }

        public bool isDogHappy()
        {
            if (Happy == true)
            {
                Console.WriteLine($"Hunden {Name} är väldigt glad idag :)");
                return true;
            }
            else
            {
                Console.WriteLine($"Hunden {Name} är inte glad idag :(");
                return false;
            }
        }

        public override void makeSound()
        {
            Console.WriteLine($"Hunden {Name} skäller högt!");
        }

    }
}
