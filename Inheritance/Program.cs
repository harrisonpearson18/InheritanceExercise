using System;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    public class Program : Animal
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            // ---------------------------------------------------------------- done
            // IMPORTANT INFO
            //public void AddCars(params Car[] cars)
            //foreach (var in cars)
            //  Cars.Add(car);
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var birdArray = new List<Bird>();
            var reptileArray = new List<Reptile>();


            var Parrot = new Bird("Parrot", true, true, true);
            Parrot.HasFur = false;
            Parrot.LegCount = 2;
            Parrot.IsPet = true;
            Parrot.HasTail = false;
            Parrot.HasFur = false;
            Parrot.Name = "Stanley";
            Parrot.BirdType = "Parrot";
            Parrot.HasFeathers = true;
            Parrot.IsFlyer = true;
            Parrot.CanTalk = true;

            var Parrot2 = new Bird("Parrot", true, true, true);
            Parrot2.HasFur = true;
            Parrot2.LegCount = 6;
            Parrot2.IsPet = false;
            Parrot2.HasTail = false;
            Parrot2.Name = "Zubat";
            Parrot2.BirdType = "Flying wombat";
            Parrot2.HasFeathers = false;
            Parrot2.IsFlyer = true;
            Parrot2.CanTalk = false;

            //Parrot.PetReturn();
            //Parrot.AnimalReturn();
            //Parrot.Flyer();
            //Parrot.PropReturn();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var Lizard = new Reptile(false, true, false, false, "Lizard");
            Lizard.HasFur = false;
            Lizard.LegCount = 4;
            Lizard.IsPet = false;
            Lizard.HasTail = true;
            Lizard.Name = "Sam the Chameleon";
            Lizard.IsSwimmer = false;
            Lizard.CanChangeColor = false;
            Lizard.ReptileType = "Chameleon";
            Lizard.IsPoisonous = false;
            Lizard.HasScales = false;

            var Lizard1 = new Reptile(false, true, false, false, "Lizard");
            Lizard1.HasFur = false;
            Lizard1.LegCount = 4;
            Lizard1.IsPet = false;
            Lizard1.HasTail = true;
            Lizard1.Name = "LizardMan";
            Lizard1.IsSwimmer = true;
            Lizard1.CanChangeColor = false;
            Lizard1.ReptileType = "SPOOKY";
            Lizard1.IsPoisonous = true;
            Lizard1.HasScales = true;

            reptileArray.Add(Lizard1);
            reptileArray.Add(Lizard);

            birdArray.Add(Parrot);
            birdArray.Add(Parrot2);

            PrintBirds(birdArray);
            PrintReptiles(reptileArray);

            //Lizard.PetReturn();
            //Lizard.AnimalReturn();
            //Lizard.ReptileReturn();
            //Lizard.ReptileInfo();



            void PrintReptiles(List<Reptile> reptileArray)
            {
                foreach (var Animal in reptileArray)
                {
                    Animal.ReptileInfo();
                }
            }

            void PrintBirds(List<Bird> birdArray)
            {
                foreach (var Animal in birdArray)
                {
                    Animal.BirdInfo();
                }
            }

        }

    }
}
