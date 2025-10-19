namespace Hangman.Classes;

public class Guess
{       //variables aswell as classes was also inspired by the help of AI as the rough projact plan was created through the help of AI.
    public string Word { get; set; }
    public int Attempts { get; set; }
    public int MaxTries { get; set; } = 6;
    public char GuessChar { get; set; }

    private List<string> Words = new List<string>()
    {       //list created with the help of AI giving word inspiration.
        "Book", "New", "Computer", "School", "Programming",
        "Window", "Bottle", "Keyboard", "Mountain", "River",
        "Planet", "Ocean", "Music", "Flower", "Bridge",
        "Garden", "Dream", "Castle", "Magic", "Robot",
        "Adventure", "Friendship", "Forest", "Camera", "Chocolate",
        "Puzzle", "Science", "Galaxy", "Thunder", "Journey",
        "Library", "Rainbow", "Dragon", "Mirror", "Treasure",
        "Victory", "Sunlight", "Courage", "Freedom", "Shadow"
    };

    public void GuessWord()
    {
        Random random = new Random();
        string randomWord = Words[random.Next(Words.Count)].ToUpper();
        HashSet<char> guessedLetters = new HashSet<char>();

        Attempts = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Hangman");
            Console.WriteLine($"Attempts: {Attempts}/{MaxTries}");
            Console.WriteLine();

            foreach (char c in randomWord)
            {       //i had problems getting this to work without asking AI. whenever I tried to do it myself
                    //it would simply give me the wrong output but with the help of AI I could figure out the problem.
                    //so this also is inspired by AI
                if (guessedLetters.Contains(c))
                    Console.Write(c + " ");
                else
                    Console.Write("_ ");
            }

            Console.WriteLine("\n");

            if (randomWord.All(c => guessedLetters.Contains(c)))
            {
                Console.WriteLine("\nYou won! the word was: " + randomWord);
                break;
            }

            if (Attempts >= MaxTries)
            {
                Console.WriteLine("\nYou lost! The word was: " + randomWord);
                break;
            }

            Console.Write("Guess a letter: ");
            GuessChar = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (guessedLetters.Contains(GuessChar))
            {
                Console.WriteLine("You already guessed that letter!");
                Thread.Sleep(1000);
                continue;
            }

            guessedLetters.Add(GuessChar);

            if (!randomWord.Contains(GuessChar))
            {
                Attempts++;
            }
        }
    }
}