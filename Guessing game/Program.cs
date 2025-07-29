namespace Guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess, number, guesses;
            string response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(1, 101);

                while (guess != number)
                {
                    Console.WriteLine($"Guess number between {min} - {max}: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too hight");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low");
                    }
                    guesses++;

                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Number of guesses is: " + guesses);
                Console.WriteLine("Play more (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks for playing!");
        }
    }
}
