namespace Lab5_OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            GoldenRetriever bella = new GoldenRetriever
            ("Bella", 9, 10, "Hona", false, true, true);

            bella.animalName();
            bella.animalAge();
            bella.colorOfAnimal();
            bella.makeSound();
            bella.isLoyal();



            BorderCollie collan = new BorderCollie
            ("Collan", 4, 3.5, "Hona", false, true, 21.7);

            collan.runFast();
            collan.makeSound();

            Bear baloo = new Bear
            ("Baloo", 5, 200, "Hane", true, 1.8);


            baloo.makeSound();
            baloo.howTall();
            baloo.animalName();
            baloo.colorOfAnimal();
            



            Cat gizmo = new Cat
            ("Gizmo", 10, 3.8, "Hane", false, 2);

            gizmo.catIsJumping();
            gizmo.makeSound();


            Dog kenzo = new Dog("Kenzo", 2, 20.5, "Hane", false, true);

            kenzo.makeSound();
            kenzo.isDogHappy();
            


                



                





        }
    }
}
