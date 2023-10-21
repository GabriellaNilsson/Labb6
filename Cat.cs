using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6
{
    
    public class Cat : Animal
    {
        //  Auto-implemented properties
        public string _eyeColour { get; set; }
        public string _coatColour { get; set; }
        public string _favoriteFood { get; set; }

        // Constructor
        public Cat(string species, string breed, string name, int age, string gender, string eyeColour = "Amber", string coatColour = "Multi-colour", string favoriteFood = "Wet food")
            : base(species, breed, name, age, gender)
        {
            _eyeColour = eyeColour;
            _coatColour = coatColour;
            _favoriteFood = favoriteFood;
        }

        // Unique methods for this class
        public void ClimbTree()
        {
            Console.WriteLine("Cats are experts at climbing trees using their claws.");
        }

        public void Purr()
        {
            Console.WriteLine("Cats usually purr when they feel content, safe and relaxed, but also to show stress or discomfort. It varies from cat to cat. They can also purr to communicate to their owners or other cats.");
        }

        public void Sleeping()
        {
            Console.WriteLine("Cat can sleep up to 20 hours per day.");
        }

        // Methods that all animals share
        public override void MakeSound()
        {
            Console.WriteLine("The cat meows.");
        }

        public override void Groom()
        {
            Console.WriteLine("Cats groom themselves by using their tongue.");
        }

        public override void Communicate()
        {
            Console.WriteLine("Cats communicate in many ways. That includes meowing, hissing and growling and purring and more. They also use a lot of body language, for example tail position, ears and whiskers.");
        }

        public override void Move()
        {
            Console.WriteLine("Cats walk on their four legs.");
        }

        // Method for printing in console
        public void PrintInfo()
        {
            Console.WriteLine($"Species: {_species}, breed: {_breed}, name: {_name}, age: {_age}, gender: {_gender}, eye colour: {_eyeColour}, coat colour: {_coatColour}, favorite food {_favoriteFood}");
        }


    }
}
