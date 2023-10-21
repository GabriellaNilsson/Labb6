using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6
{
        
        public class Fox : Animal
        {
            // Auto-implemented properties
            public string _dietaryPreference { get; set; }

            // Constructor
            public Fox(string species, string breed, string name, int age, string gender, string dietaryPreference = "Omnivore")
                : base(species, breed, name, age, gender)
            {
                _dietaryPreference = dietaryPreference;
            }

            // Unique method for this class
            public void SneakInStealth()
            {
                Console.WriteLine("Foxes use sneaking to get to their prey");
            }

            // Methods that all animals share
            public override void MakeSound()
            {
                Console.WriteLine("What does the fox say? Well, it's a difficult thing to explain. They kinda make a high pitch and eerie sound");
            }

            public override void Groom()
            {
                Console.WriteLine("Foxes groom themselves by licking their fur, biting and chewing and scratching.");
            }

            public override void Communicate()
            {
                Console.WriteLine("Foxes communicate by barking, howling, screaming and whining. They also use body language, for example tail position, ear position and posture.");
            }

            public override void Move()
            {
                Console.WriteLine("Foxes walk on their four legs");
            }

            // Method for printing in console
            public void PrintInfo()
            {
                Console.WriteLine($"Species: {_species}, breed: {_breed}, name: {_name}, age: {_age}, gender: {_gender}, dietary preference: {_dietaryPreference}");
            }
        }   
}
