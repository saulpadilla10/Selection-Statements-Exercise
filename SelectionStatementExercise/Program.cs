namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Play a game? Guess my favorite number!");
            Console.WriteLine("Input now.");

            var guessE = int.Parse(Console.ReadLine());
           

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
