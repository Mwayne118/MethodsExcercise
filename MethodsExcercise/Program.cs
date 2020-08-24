using System;

namespace MethodsExcercise
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2; 
            return answer;


        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        static void Main(string[] args)
        {
            var amountofCars = Sum(2, 6);
            var blah = Multiply(60, 2, 4);




            Console.WriteLine("Hello - What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great! Now, what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}! Enclosed is your profile!");


            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Band: {band}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Color: {color}");



            //-----------------Excercise 2------------------------------

            Console.WriteLine($"The sume is: {Sum(20, 30)}");
        }
    }
}
