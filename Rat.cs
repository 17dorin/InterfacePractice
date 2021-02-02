using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterface
{
    class Rat : IAnimal
    {
        public string Name { get { return _name; } set { _name = value; } }
        private string _name;
        public bool HasFeathers { get { return _hasFeathers; } set { _hasFeathers = value; } }
        private bool _hasFeathers;
        public int SocialSecurity { get { return _socialSecurity; } set { _socialSecurity = value; } }
        private int _socialSecurity;

        public Rat(string Name, int SocialSecurity)
        {
            this.Name = Name;
            this.SocialSecurity = SocialSecurity;
            this.HasFeathers = false;
        }

        public bool CanFly()
        {
            Console.WriteLine("Rats cannot fly");
            return false;
        }

        public void MakeSound()
        {
            Console.WriteLine("Squeak");
        }

        public void PrintTaxInfo()
        {
            Console.WriteLine($"{Name} did their taxes, AND reported the cat to the IRS");
        }
    }
}
