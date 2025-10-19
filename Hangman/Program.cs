using Hangman.Classes;

class Program
{
    static void Main(string[] args)
    {
        Guess game = new Guess();

        game.GuessWord();

        Console.WriteLine("\nPress any button to exit");
        Console.ReadKey();
    }
}