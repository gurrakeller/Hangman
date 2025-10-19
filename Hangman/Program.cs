using Hangman.Classes;

class Program
{
    static void Main(string[] args)
    {       //i was unsure if i really did this the correct way as program is almost empty seeing as all the logic acually happens in the Guess class. after asking AI
            //however he helped me realize that in modern programming this is often the way its suppsed to be as we want to seperate it as much as possible.
        Guess game = new Guess();

        game.GuessWord();

        Console.WriteLine("\nPress any button to exit");
        Console.ReadKey();
    }
}