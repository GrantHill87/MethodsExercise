﻿using System;

namespace Method_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            String Name;
            Name = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            String favoriteAnimal;
            favoriteAnimal= Console.ReadLine();

            Console.WriteLine("If you had a color preference, what would it be?");
            String favoriteColor;
            favoriteColor= Console.ReadLine();

            Console.WriteLine("Any favorite music? If so, what group?");
            String favoriteBand;
            favoriteBand= Console.ReadLine();
            
            Console.WriteLine($"Once upon a time, there lived an individual named, {Name}, who was very jolly, happy go-lucky.");
            Console.WriteLine($"{Name}, had a young {favoriteAnimal}, which they looked after and took care of.... even took on exotic trips! Sometimes, they would even venture to live concerts together.");
            Console.WriteLine($"{Name}'s {favoriteAnimal} also happened to be a vivacious shade of {favoriteColor}.");
            Console.WriteLine($"Could you imagine a {favoriteColor} {favoriteAnimal}? I could! In fact I've seen dozens of them!");
            Console.WriteLine($"As it turned out, {Name}, and their beloved {favoriteAnimal} often attended {favoriteBand} concerts -- like you wouldn't believe.");
            Console.WriteLine($"That {favoriteColor} {favoriteAnimal} went straight to the mash pit, without {Name}.");


        }
    }
}
