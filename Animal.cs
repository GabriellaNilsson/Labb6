using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6
{
    public class Animal
    {
        // Auto-implemented properties
        public string _species { get; set; }
        public string _breed { get; set; }
        public string _name { get; set; }
        public int _age { get; set; }
        public string _gender { get; set; }

        // Constructor
        public Animal(string species, string breed , string name, int age, string gender)
        {
            _species = species;
            _breed = breed;
            _name = name;
            _age = age;
            _gender = gender;
        }

        // Methods that all animals share
        public virtual void MakeSound()
        {
            
        }

        public virtual void Groom()
        {
            
        }

        public virtual void Communicate()
        {
            
        }

        public virtual void Move()
        {
            
        }
    }
}
