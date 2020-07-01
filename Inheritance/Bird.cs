using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird(string birdType, bool hasFeathers, bool isFlyer, bool canTalk)
        {
            BirdType = birdType;
            HasFeathers = hasFeathers;
            IsFlyer = isFlyer;
            CanTalk = canTalk;
        }

        public string BirdType { get; set; }

        public bool HasFeathers { get; set; }
        public bool IsFlyer { get; set; }
        public bool CanTalk { get; set; }

        public void Flyer()
        {
            if(IsFlyer == true)
            {
                Console.WriteLine("The " + BirdType + " is able to fly.");
            }
            else
            {
                Console.WriteLine("The " + BirdType + " is not able to fly.");
            }
        }

        public void PropReturn()
        {
            if (HasFeathers && CanTalk == true)
            {
                Console.WriteLine($"{Name} has feathers and can talk");
            }

            else if (HasFeathers == false && CanTalk == true)
            {
                Console.WriteLine($"{Name} does not have feathers and can talk");
            }

            else if (HasFeathers && CanTalk == false)
            {
                Console.WriteLine($"The {BirdType} does not have feathers and cannot talk");
            }


        }

        public void BirdInfo()
        {
            AnimalInfo();
            Console.WriteLine($"Bird Type: {BirdType}");
            Console.WriteLine($"Has Feathers: {HasFeathers}");
            Console.WriteLine($"Flyer: {IsFlyer}");
            Console.WriteLine($"Can Talk: {CanTalk}");


        }

    }
}
