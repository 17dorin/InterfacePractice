using System;
using System.Collections.Generic;

namespace AbstractAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat("Brick", 45125896);
            Rat r = new Rat("Jerry", 12356487);
            Owl o = new Owl("Horacio", 89874562);

            List<IAnimal> animals = new List<IAnimal> { c, r, o };

            foreach(IAnimal animal in animals)
            {
                Console.WriteLine();
                animal.CanFly();
                animal.MakeSound();
                animal.PrintTaxInfo();
            }
            Console.WriteLine();


        }
    }
}
