using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterface
{
    class Owl : IAnimal
    {
        public string Name { get { return _name; } set { _name = value; } }
        private string _name;
        public bool HasFeathers { get { return _hasFeathers; } set { _hasFeathers = value; } }
        private bool _hasFeathers;
        public int SocialSecurity { get { return _socialSecurity; } set { _socialSecurity = value; } }
        private int _socialSecurity;

        public Owl(string Name, int SocialSecurity)
        {
            this.Name = Name;
            this.SocialSecurity = SocialSecurity;
            this.HasFeathers = true;
        }

        public void MakeSound()
        {
            Console.WriteLine("Who");
        }

        public bool CanFly()
        {
            Console.WriteLine("Owl's can fly");
            return true;
        }

        public void PrintTaxInfo()
        {
            Console.WriteLine($"{Name} owns a large company and abused a tax loophole to pay no taxes");
        }
    }
}
