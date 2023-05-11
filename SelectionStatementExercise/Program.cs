namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Play a game? Guess my favorite number!");
            Console.WriteLine("Input now.");

            string input = Console.ReadLine();

            int guessE = int.Parse(input);

            var favNumber = 70;
           

            if (guessE < favNumber)
            {
                Console.WriteLine("Too low.");
            }
            else if (guessE > favNumber)
            {
                Console.WriteLine("Too high! Try again");
            }
            else
            {
                Console.WriteLine($"Nevermind.");
            }








        }
    }
}
