namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the guessing game!");
            Console.WriteLine("Would you like to take a guess?");

            var userResponse = Console.ReadLine();

            Console.WriteLine("Let's get started!");
            Console.WriteLine("Take your guess!");

            var random = new Random();
            var favNumber = random.Next(1,10);

            var userInput = int.Parse(Console.ReadLine());

            if (favNumber > userInput)
            {
                Console.WriteLine("Too low!");
            }
            else if (favNumber < userInput)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("Correct!");
            }
        }
    }
}
