using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6
{
    internal class ScottishFold : Cat
    {
        // Auto-implemented properties
        public string _healthProblems { get; set; } 

        // Constructor
        public ScottishFold(string species, string breed, string name, int age, string gender, string eyeColour, string coatColour, string favoriteFood, string healthProblems = "Folded ears")
            : base (species, breed, name, age, gender, eyeColour, coatColour, favoriteFood)
        {
            _healthProblems = healthProblems; 
        }

        // Unique method for this class
        public void RoundAppearance()
        {
            Console.WriteLine("These cats are known to have a rather round appearance, for example round face and paws.");
        }

        // Make-Sound method
        public override void MakeSound()
        {
            Console.WriteLine("The scottish fold cat meows.");
        }

        // Method for printing in console
        public void ShowInfo()
        {
            Console.WriteLine($"Species: {_species}, breed: {_breed}, name: {_name}, age: {_age}, gender: {_gender}, eye colour: {_eyeColour}, coat colour: {_coatColour}, favorite food {_favoriteFood}, health problems: {_healthProblems}");
        }
    }
}
