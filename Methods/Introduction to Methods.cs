using System;

namespace Optional_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalSound("dog", "bark");
        }
        static void AnimalSound(string animal = "duck", string sound = "quack")
        {
            Console.WriteLine($"The {animal} goes {sound}!");
        }


        // Calls the two-parameter method with a default sound
        //static void AnimalSound(string animal)
        //{
        //    AnimalSound(animal, "quack");
        //}


        //// Calls the one-parameter method with a default animal
        //static void AnimalSound()
        //{
        //    AnimalSound("duck");
        //}
    }
}
