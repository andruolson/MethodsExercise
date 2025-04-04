﻿namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number:");
            int numOne = int.Parse(Console.ReadLine()); //Takes string input and changes it into an int...

            Console.WriteLine("Great! Now enter your second number:");
            int numTwo = int.Parse(Console.ReadLine()); //Takes string input and changes it into an int...

            Console.WriteLine("Here are your answers...");
            
            int addResult = AdditionMethod(numOne, numTwo);
            Console.WriteLine($"Addition = {addResult}");
            
            int subResult = SubtractionMethod(numOne, numTwo);
            Console.WriteLine($"Subtraction = {subResult}");
            
            int mulResult = MultiplicationMethod(numOne, numTwo);
            Console.WriteLine($"Multiplication = {mulResult}");
            
            int divResult = DivisionMethod(numOne, numTwo);
            Console.WriteLine($"Division = {divResult}");
            

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine(); //user will type their name here
            Console.WriteLine("What's your favorite color?");
            string favColor = Console.ReadLine(); //user will type their favorite color
            Console.WriteLine("What's your favorite animal?");
            string favAnimal = Console.ReadLine(); //user will type their favorite animal
            Console.WriteLine("What's your favorite food?");
            string favFood = Console.ReadLine(); //user will type their favorite food

            WriteStory(userName, favColor, favAnimal, favFood);
        
         }
        

        public static int AdditionMethod(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
        
        public static int SubtractionMethod(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }
        
        public static int MultiplicationMethod(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }
        
        public static int DivisionMethod(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }
        
        public static void WriteStory(string userName, string favColor, string favAnimal, string favFood)
        {
            Console.WriteLine($"My name is {userName}, I have lots of favorite colors, but I'd say my absolute favorite color is {favColor}.\n" +
              $"When I go to the zoo, I always want to go see the {favAnimal}.\nCause that is my absolute favorite animal! " +
              $"After the zoo I'm always super hungry,\nmost of the time I go get some {favFood}\n...There really isn't anything better than {favFood}!");
        }

    }
}
