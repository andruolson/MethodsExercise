namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine(); //user will type their name here
            Console.WriteLine("What's your favorite color?");
            string favcolor = Console.ReadLine(); //user will type their favorite color
            Console.WriteLine("What's your favorite animal?");
            string favanimal = Console.ReadLine(); //user will type their favorite animal
            Console.WriteLine("What's your favorite food?");
            string favfood = Console.ReadLine(); //user will type their favorite food
            
            //Below is the story that will be written to the console
           Console.WriteLine($"My name is {name}, I have lots of favorite colors, but I'd say my absolute favorite color is {favcolor}.\n" +
                             $"When I go to the zoo, I always want to go see the {favanimal}.\nCause that is my absolute favorite animal! " +
                             $"After the zoo I'm always super hungry,\nmost of the time I go get some {favfood}\n...There really isn't anything better than {favfood}!");
        }
    }
}
