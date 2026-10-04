using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_OOP_Arv
{
    internal class Cat : Animal
    {

        public int Jump { get; set; }

        public Cat (string name, int age, double weight, string gender, bool wildanimal, int jump) : base (name, age, weight, gender, wildanimal)
        { 
            Jump = jump;
        }

        public void catIsJumping()
        {
            Console.WriteLine($"Katten {Name} som är {Age} år gammal hoppar {Jump} meter högt!");
        }

        public override void makeSound()
        {
            Console.WriteLine($"Katten {Name} jamar!");
        }

    }
}
