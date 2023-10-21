using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Labb6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating instance:
            
            Cat myCat = new Cat("Domestic cat", "British Shorthair", "Max", 2, "Male", "Pale Green-grey", "White", "Wet food");
            Cat myCat2 = new Cat("Domestic cat", "British Shorthair", "Luna", 3, "Female");
            Owl myOwl = new Owl("Snowy owl", "404 Does not exist", "Hedwig", 5, "Female");
            Fox myFox = new Fox("Red fox", "404 Does not exist", "Unknown", 1, "Unknown");
            Siamese mySiamese = new Siamese("Cat", "Siamese", "Unknown", 1, "Male", "Blue", "Point coloration", "Unknown");
            ScottishFold myScottishFold = new ScottishFold("Cat", "Scottish fold", "Unknown", 1, "Female", "Female", "Grey", "Unknown");


            // Printing methods (down below):
            
            Console.WriteLine("Objects created:\n");
            myCat.PrintInfo();
            myCat2.PrintInfo();
            myFox.PrintInfo();
            myOwl.PrintInfo();
            mySiamese.ShowInfo();
            myScottishFold.ShowInfo();

            // Make-Sound method
            Console.WriteLine("\nAll animals making sounds:");
            myFox.MakeSound();
            myOwl.MakeSound();
            myCat.MakeSound();
            myCat2.MakeSound();
            mySiamese.MakeSound();
            myScottishFold.MakeSound();

            // Fox class
            Console.WriteLine("\nThe fox:");
            myFox.Groom();
            myFox.Communicate();
            myFox.Move();
            myFox.SneakInStealth();

            // Owl class
            Console.WriteLine("\nThe owl:");
            myOwl.Groom();
            myOwl.Communicate();
            myOwl.Move();
            myOwl.NightVisionHunt();

            // Cat class
            Console.WriteLine("\nThe cat:");
            myCat.Groom();
            myCat.Communicate();
            myCat.Move();
            myCat.ClimbTree();
            myCat.Purr();
            myCat.Sleeping();

            // Scottish fold class (inherits from the cat class)
            Console.WriteLine("\nThe cat breed scottish fold:");
            myScottishFold.RoundAppearance(); // Method unique for scottish fold class
            myScottishFold.Sleeping(); // Method from the cat class

            // Siamese class (inherits from the cat class)
            Console.WriteLine("\nThe cat breed siamese:");
            mySiamese.Vocal(); // Method unique for siamese class
            mySiamese.Groom(); // Method from the cat class 
        }
    }
}