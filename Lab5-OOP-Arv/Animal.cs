using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_OOP_Arv
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string MaleFemale { get; set; }
        public bool WildAnimal { get; set; }

        public Animal(string name = "Okänt namn", int age = 0, double weight = 0.0, string gender = "Okänt kön", bool wildanimal = false)
        {
            Name = name;
            Age = age;
            Weight = weight;
            MaleFemale = gender;
            WildAnimal = wildanimal;
        }


        public void animalName()
        {
            Console.WriteLine($"{Name} är namnet på djuret");
        }

        public void animalAge()
        {
            Console.WriteLine($"{Name} är {Age} gammal.");
        }

        public void colorOfAnimal()
        {
            Console.WriteLine($"Vad har {Name} för färg?");
            string animalc = Console.ReadLine();
            Console.WriteLine($"Färgen på {Name} är: " + animalc);
        }


        public virtual void makeSound()
        {
            Console.WriteLine($"{Name} gör ett ljud!");
        }


    }

}
