namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Exercise 1:
               Write a C# program that takes user input and creates a story. Ask the user for things like a name, color, an animal, etc. Make up a story and be creative. Hint: Use Console.ReadLine() to take user input and store the input into a variable.
               
               Ask the user “What is your name?” Store the input.
               
               EXAMPLE:
               
               Console.WriteLine("What is your name?"); // output
               var name = Console.ReadLine(); // input
               Record user input, for each of these. Combine all answers for a fun, short story.
               
               EXAMPLES:
               
               Name: Michael
               
               Favorite Color: Blue
               
               Favorite Animal: Walrus
               
               Favorite Band: The Beatles
               
               Extra points - turn the answers into a fun short story! Save, commit, and push to Github */

            Console.WriteLine("Hey! What is your first name?");
            string firstName = Console.ReadLine();
            
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            
            Console.WriteLine($"Nice to meet you {firstName} {lastName}");
            Console.WriteLine("");
            
            Console.WriteLine("What is your favorite color?");
            string favColor = Console.ReadLine();
            
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();
            
            Console.WriteLine("What is your favorite band?");
            string favBand = Console.ReadLine();
            
            Console.WriteLine($"Hey {firstName} {lastName} ...It's nice to meet you... So your favorite" +
                              $" color is {favColor} and your favorite animal is a {favAnimal}? ...That's weird...Really..." +
                              $" a {favAnimal}? That's strange, but I won't judge you... And you like to listen to music" +
                              $" by the band {favBand}? ...Ok, well... I said I wouldn't judge you... but I am hardcore.");

        }
    }
}
