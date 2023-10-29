using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv___Linus_Aspelöf_SUT23
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public int Weight { get; set; }
        public int LegCount { get; set; }

        public Animal(string name = "Djur", int age = 0, string color = "Okänd", 
            int weight = 0, int legCount = 0)
        {
            Name = name;
            Age = age;
            Color = color;
            Weight = weight;
            LegCount = legCount;
        }

        public void Legs()
        {
            Console.WriteLine($"\n\tEn {Name} har {LegCount} ben.");
        }
        public void Eat()
        {
            Console.WriteLine($"\n\tEn {Name} äter.");
        }
        public void Sleep()
        {
            Console.WriteLine($"\n\tEn {Name} sover.");
        }
        public virtual void MakeSound()
        {
            Console.WriteLine($"\n\tEn {Name} gör ett generellt ljud.");
        }
    }
    class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name = "Hund", int age = 0, string color = "Okänd", 
            int weight = 0, int legCount = 4, string breed = "Okänd")
        : base(name, age, color, weight, legCount)
        {
            Breed = breed;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"\n\tEn {Name} skäller.");
        }
        public void Chase()
        {
            Console.WriteLine($"\n\tEn {Name} jagar sin svans.");
        }
    }
    class Dachshund : Dog
    {
        public bool ShortLegs { get; set; }

        public Dachshund(string name = "Hund", int age = 0, string color = "Okänd", 
            int weight = 0, int legCount = 4, string breed = "Tax", bool shortLegs = true)
        : base(name, age, color, weight, legCount, breed)
        {
            ShortLegs = shortLegs;
        }
        public void HasShortLegs()
        {
            if (ShortLegs)
            {
                Console.WriteLine($"\n\tEn {Breed} har korta ben.");
            }
        }
    }
    class Shepherd : Dog
    {
        public bool IsHerdDog { get; set; }

        public Shepherd(string name = "Hund", int age = 0, string color = "Okänd", 
            int weight = 0, int legCount = 4, string breed = "Schäfer", bool isHerdDog = true)
        : base(name, age, color, weight, legCount, breed)
        {
            IsHerdDog = isHerdDog;
        }
        public void HasShortLegs()
        {
            if (IsHerdDog)
            {
                Console.WriteLine($"\n\tEn {Breed} är bra en vallnings hund.");
            }
        }
    }
    class Cat : Animal
    {
        public bool IsHouseCat { get; set; }

        public Cat(string name = "Katt", int age = 0, string color = "Okänd", 
            int weight = 0, int legCount = 4, bool isHouseCat = false)
        : base(name, age, color, weight, legCount)
        {
            IsHouseCat = isHouseCat;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"\n\tEn {Name} jamar.");
        }
        public void Stuck()
        {
            Console.WriteLine($"\n\tEn {Name} är fast i ett träd.");
        }
    }
    class Chicken : Animal
    {
        public bool CanLayEggs { get; set; }

        public Chicken(string name = "Kyckling", int age = 0, string color = "Okänd", 
            int weight = 0, int legCount = 2, bool canLayEggs = true)
        : base(name, age, color, weight, legCount)
        {
            CanLayEggs = canLayEggs;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"\n\tEn {Name} gal.");
        }
        public void LayEggs()
        {
            if (CanLayEggs)
            {
                Console.WriteLine($"\n\tEn {Name} kan lägga ägg.");
            }
        }
    }
}
