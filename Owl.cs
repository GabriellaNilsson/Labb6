using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6
{
    
    public class Owl : Animal
    {
        // Auto-implemented properties

        public string _huntingTime { get; set; }
        
        // Constructor
        public Owl(string species, string breed, string name, int age, string gender, string huntingTime = "Night") 
            : base(species, breed, name, age, gender)
        {
            _huntingTime = huntingTime;
        }

        // Unique method for this class
        public void NightVisionHunt()
        {
            Console.WriteLine("Owls, who have night vision, hunt for prey in the darkness.");
        }

        // Methods that all animals share
        public override void MakeSound()
        {
            Console.WriteLine("The owl hoots and screeches.");
        }

        public override void Groom()
        {
            Console.WriteLine("Owls clean themselves by using their beak. They clean the base of the feathers, talons and feet, among other things.");
        }

        public override void Communicate()
        {
            Console.WriteLine("Owls communicate by hooting, screeching and making clicking, chirping and chittering sounds.");
        }

        public override void Move()
        {
            Console.WriteLine("Owls move around by using their wings.");
        }

        // Method for printing in console
        public void PrintInfo()
        {
            Console.WriteLine($"Species: {_species}, breed: {_breed}, name: {_name}, age: {_age}, gender: {_gender}, hunting time: {_huntingTime}");
        }
    }
}
