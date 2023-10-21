using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labb6
{
    internal class Siamese : Cat
    {
        // Auto-implemented properties
        public string _bodyType { get; set; } 
        
        // Constructor
        public Siamese(string species, string breed, string name, int age, string gender, string eyeColour, string coatColour, string favoriteFood, string bodyType = "Slender body")
            : base (species, breed, name, age, gender, eyeColour, coatColour, favoriteFood)
        {
            _bodyType = bodyType; 
        }

        // Unique method for this class
        public void Vocal ()
        {
            Console.WriteLine("Siamese cats are very vocal compared to other breeds.");
        }

        // Make-Sound method
        public override void MakeSound()
        {
            Console.WriteLine("The siamese cat meows.");
        }

        // Method for printing in console
        public void ShowInfo()
        {
            Console.WriteLine($"Species: {_species}, breed: {_breed}, name: {_name}, age: {_age}, gender: {_gender}, eye colour: {_eyeColour}, coat colour: {_coatColour}, favorite food: {_favoriteFood}, body type: {_bodyType}");
        }
    }
}
