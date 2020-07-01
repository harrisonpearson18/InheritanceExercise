using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile(bool isSwimmer, bool hasScales, bool isPoisonous, bool canChangeColor, string reptileType)
        {
            IsSwimmer = isSwimmer;
            HasScales = hasScales;
            IsPoisonous = isPoisonous;
            CanChangeColor = canChangeColor;
            ReptileType = reptileType;

        }


        public bool IsSwimmer { get; set; }
        public bool HasScales { get; set; }
        public bool IsPoisonous { get; set; }
        public bool CanChangeColor { get; set; }

        public string ReptileType { get; set; }

        public void ReptileReturn()
        {
            if (IsSwimmer && HasScales == true)
            {
                Console.WriteLine($"{ReptileType} is able to swim and has scales");
            }
            else if (IsSwimmer == false && HasScales == true)
            {
                Console.WriteLine($"{ReptileType} has scales but cannot swim");
            }
            else if (IsSwimmer == true && HasScales == false)
            {
                Console.WriteLine($"{ReptileType} is a swimmer without scales");
            }
            else
            {
                Console.WriteLine($"{ReptileType} is a land species that cannot swim and does not have scales");
            }
        }

        public void ReptileInfo()
        {
            AnimalInfo();
            Console.WriteLine($"Type: {ReptileType}");
            Console.WriteLine($"Dangerous? : {IsPoisonous}");
            Console.WriteLine($"Scales: {HasScales}");
            Console.WriteLine($"Color Changer : {CanChangeColor}");
            Console.WriteLine($"Amphibious: {IsSwimmer}");


        }
    }
}
