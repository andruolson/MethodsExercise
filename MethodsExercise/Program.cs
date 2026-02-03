namespace MethodsExercise
{
    public class Program
    {
        //METHOD 1 - ADDITION
        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }
        
        //METHOD 2 - SUBTRACTION
        public static int SubtractNumbers(int a, int b)
        {
            return a - b;
        }
        
        //METHOD 3 - MULTIPLICATION
        public static int MultiplyNumbers(int a, int b)
        {
            return a * b;
        }
        
        //METHOD 4 - DIVISION
        public static int DivideNumbers(int a, int b)
        {
            return a / b;
        }
        
        
        static void Main(string[] args)
        {
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
            
            Thread.Sleep(2000); 
            Console.WriteLine("----------------------------------");
            Console.WriteLine("PLEASE WAIT");
            Thread.Sleep(2000); 
            Console.WriteLine("----------------------------------");
            Thread.Sleep(2000); 
            Console.WriteLine(" ");

            Console.WriteLine("Give me a number");
            int userNum1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Give me another number");
            int userNum2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Addition: " + AddNumbers(userNum1, userNum2));
            Console.WriteLine("Subtraction: " + SubtractNumbers(userNum1, userNum2));
            Console.WriteLine("Multiplication: " + MultiplyNumbers(userNum1, userNum2));
            Console.WriteLine("Division: " + DivideNumbers(userNum1, userNum2));



        }
    }
}
