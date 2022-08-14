using System;

namespace Method_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Story telling, utilizing string reference based variable in main method.
            Console.WriteLine("What is your name?");
            String Name;
            Name = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            String favoriteAnimal;
            favoriteAnimal = Console.ReadLine();

            Console.WriteLine("If you had a color preference, what would it be?");
            String favoriteColor;
            favoriteColor = Console.ReadLine();

            Console.WriteLine("Any favorite music? If so, what group?");
            String favoriteBand;
            favoriteBand = Console.ReadLine();

            Console.WriteLine($"Once upon a time, there lived an individual named, {Name}, who was very jolly, happy go-lucky.");
            Console.WriteLine($"{Name}, had a young {favoriteAnimal}, which they looked after and took care of.... even took on exotic trips! Sometimes, they would even venture to live concerts together.");
            Console.WriteLine($"{Name}'s {favoriteAnimal} also happened to be a vivacious shade of {favoriteColor}.");
            Console.WriteLine($"Could you imagine a {favoriteColor} {favoriteAnimal}? I could! In fact I've seen dozens of them!");
            Console.WriteLine($"As it turned out, {Name}, and their beloved {favoriteAnimal} often attended {favoriteBand} concerts -- like you wouldn't believe.");
            Console.WriteLine($"That {favoriteColor} {favoriteAnimal} went straight to the mosh pit, without {Name}.");

            Console.WriteLine("Thank you for your response; onto the next part of the exercise.");

            //Initializing mathematical methods via user input.
            Console.WriteLine("If you wouldn't mind, please provide me with a number.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Now, shout out the first number that comes to mind!");
            int num2 = int.Parse(Console.ReadLine());

            int sum1 = Sum(num1, num2);
            Console.WriteLine($"With your numbers combined, I give you {sum1}.");

            Console.WriteLine("I'm thinking of a number, can you guess what it is??");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Cool, I'm thinking of another number.... tell me what you think.");
            int num4 = int.Parse(Console.ReadLine());

            int sum2 = Subtract(num3, num4);
            Console.WriteLine($"We're going to deduct those numbers from each other, and the conclusion is {sum2}.");

            Console.WriteLine("What number are you thinking of?");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Did you have another number in mind?");
            int num6 = int.Parse(Console.ReadLine());

            int sum3 = Multiply(num5, num6);
            Console.WriteLine($"Multiplied together, your repsonses equal {sum3}.");

            Console.WriteLine("What year were you born?");
            int num7 = int.Parse(Console.ReadLine());
            Console.WriteLine("How old are you?");
            int num8 = int.Parse(Console.ReadLine());

            int sum4 = Divide(num7, num8);
            Console.WriteLine($"You have exactly {sum4} brain farts daily.");
        }
        public static int Sum(int num1, int num2)
        {
            //Declaring mathematical methods.
            int sum = num1 + num2;
            return sum;
        }
        public static int Subtract(int num3, int num4)
        {
            //Declaring mathematical methods.
            int Subtract = num3 - num4;
            return Subtract;
        }
        public static int Multiply(int num5, int num6)
        {
            //Declaring mathematical methods.
            int Multiply = num5 * num6;
            return Multiply;
        }
        public static int Divide(int num7, int num8)
        {
            //Declaring mathematical methods.
            int Divide = num7 / num8;
            return Divide;
        }
        public static int Sum5(int v, params int[] list)
        {
            int Sum5 = 0;
            int i = 0;
            for (v = 0; i < list.Length; i++)
            {
                Sum5 = Sum5 + list[i];
            }
            return Sum5;
        }
    }
}
