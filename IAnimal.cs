using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterface
{
    public interface IAnimal
    {
        public string Name { get; set; }
        public bool HasFeathers { get; set; }
        public int SocialSecurity { get; set; }

        //Cannot make a constructor in an interface

        public void MakeSound();

        public bool CanFly();

        public void PrintTaxInfo();
    }
}
