using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Inheritance
{
    public class Animal
    {

        public Animal()
        {

        }

        public bool HasFur { get; set; }
        public int LegCount { get; set; }
        public bool IsPet { get; set; }
        public bool HasTail { get; set; }
        public string Name { get; set; }

        // public string temp1 = (HasFur == true) ? $"Yes" : $"No";
        //readonly string temp2 = (IsPet == true) ? $"Yes" : "No";
        //string temp3 = (HasTail = true) ? "No" : "Yes";



        public void PetReturn()
        {
            if(IsPet == true)
            {
                Console.WriteLine($"{Name} is a domesticated animal");
            }
            else
            {
                Console.WriteLine($"This animal is not domesticated");
            }
        }
        public void AnimalReturn()
        {
            if (HasFur && HasTail == true)
            {
                Console.WriteLine($"{Name} has fur and a tail");
            }
            else if (HasFur == true && HasTail == false)
            {
                Console.WriteLine($"{Name} has fur and no tail");
            }
            else if (HasFur == false && HasTail == true)
            {
                Console.WriteLine($"{Name} has a tail and no fur");
            }
            else if (HasFur && HasTail == false)
            {
                Console.WriteLine($"{Name} has no tail or fur");
            }
            }
        public void AnimalInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Fur: {HasFur}");
            Console.WriteLine($"Number of legs: {LegCount}");
            Console.WriteLine($"Animal is a pet: {IsPet}");
            Console.WriteLine($"Animal has a tail: {HasTail}");
        }



    }
}
