namespace MethodsExercise
{
    public class Program
    {
        public static void WriteTheStory(string name, string color, string animal, string band)
        {
            Console.WriteLine($"{name} was walking down the road... The sky light up {color}... Everywhere he looked " +
            $"he saw {animal}'s all over the place! As he was walking he heard his favorite band " +
            $"{band} playing in the distance... Today was a good day!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            
            Console.WriteLine("Nice, that's my favorite color too!");
            Console.WriteLine("Two more questions and then i'll be all done!");
            Console.WriteLine("What is your favorite animal? Type your favorite animal out singular not plural");
            string animal = Console.ReadLine();
            
            Console.WriteLine("Finally, what is your favorite band?");
            string band = Console.ReadLine();
            
            Console.WriteLine("Thanks for all the info!");
            Console.WriteLine("Thinking...");
            Console.WriteLine("Thinking...");
            Console.WriteLine("Thinking...");
            Console.WriteLine("Thinking...");
            Console.WriteLine("........");

            WriteTheStory(name, color, animal, band); 
            //Console.WriteLine($"{name} was walking down the road... The sky light up {color}... Everywhere he looked " +
            //  $"he saw {animal}'s all over the place! As he was walking he heard his favorite band " +
            //  $"{band} playing in the distance... Today was a good day!");


        }
    }
}
