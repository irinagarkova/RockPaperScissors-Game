namespace RockPaperScissorsGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] options = { "rock", "paper", "scissors" };
            Random random = new Random();

            int wins = 0;
            int losses = 0;
            int draws = 0;

            Console.WriteLine("Welcome to Rock - Paper - Scissors!");

            bool playAgain = true;

            while (playAgain)
            {
                Console.WriteLine();
                Console.Write("Choose (rock/paper/scissors): ");
                string playerChoice = Console.ReadLine().ToLower();

                if (!Array.Exists(options, option => option == playerChoice))
                {
                    Console.WriteLine("Invalid choice! Try again.");
                    continue;
                }

                int computerIndex = random.Next(options.Length);
                string computerChoice = options[computerIndex];

                Console.WriteLine($"You chose: {playerChoice}");
                Console.WriteLine($"Computer chose: {computerChoice}");

                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("It's a draw! Nobody wins.");
                    draws++;
                }
                else if (
                    (playerChoice == "rock" && computerChoice == "scissors") ||
                    (playerChoice == "scissors" && computerChoice == "paper") ||
                    (playerChoice == "paper" && computerChoice == "rock")
                )
                {
                    Console.WriteLine("You win! You're a champion!");
                    wins++;
                }
                else
                {
                    Console.WriteLine("Oops! Computer wins this round.");
                    losses++;
                }

                Console.WriteLine($"Current score: Wins: {wins} |  Losses: {losses} |  Draws: {draws}");

                Console.Write("Do you want to play again? (Yes/No): ");
                string answer = Console.ReadLine().ToLower();
                if (answer != "yes")
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("\n Game Over!");
            Console.WriteLine($"Final score:");
            Console.WriteLine($"Wins: {wins}");
            Console.WriteLine($"Losses: {losses}");
            Console.WriteLine($"Draws: {draws}");
            Console.WriteLine("Thanks for playing! See you next time!");
        }
    }
}

