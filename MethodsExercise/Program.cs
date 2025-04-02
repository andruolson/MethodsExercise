namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("What is your name?");
           string userName = Console.ReadLine(); //user will type their name here
           Console.WriteLine("What's your favorite color?");
           string favColor = Console.ReadLine(); //user will type their favorite color
           Console.WriteLine("What's your favorite animal?");
           string favAnimal = Console.ReadLine(); //user will type their favorite animal
           Console.WriteLine("What's your favorite food?");
           string favFood = Console.ReadLine(); //user will type their favorite food

           WriteStory(userName, favColor, favAnimal, favFood); 
           // Below is the story that will be written to the console
           //Console.WriteLine($"My name is {name}, I have lots of favorite colors, but I'd say my absolute favorite color is {favcolor}.\n" +
                            // $"When I go to the zoo, I always want to go see the {favanimal}.\nCause that is my absolute favorite animal! " +
                            // $"After the zoo I'm always super hungry,\nmost of the time I go get some {favfood}\n...There really isn't anything better than {favfood}!");
        }

        public static void WriteStory(string userName, string favColor, string favAnimal, string favFood)
        {
            Console.WriteLine(
                $"My name is {userName}, I have lots of favorite colors, but I'd say my absolute favorite color is {favColor}.\n" +
                $"When I go to the zoo, I always want to go see the {favAnimal}.\nCause that is my absolute favorite animal! " +
                $"After the zoo I'm always super hungry,\nmost of the time I go get some {favFood}\n...There really isn't anything better than {favFood}!");
        }

    }
}
