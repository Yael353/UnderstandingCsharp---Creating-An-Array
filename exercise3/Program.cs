namespace exercise3
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //Create a game similar to hangman in which a player guesses letters to try to replicate a hidden word
            //Store at least eight words in an array, and randomly select one to be the hidden words.
            //display the hidden word using asterisks to represent each letter.
            //allow user to guess letters to replace the asterisks until the word is completed
            //make sure each letter is placed

            //----Hint----
            /*
             * string internal array
             * strings contains method
             * string remove
             * string insert
             * string length property
             */

            Console.WriteLine("Welcome! Enter user name.");
            string player = Console.ReadLine();


            //Creating the random word.
            string[] word = new string[] { "potatoes", "book", "display", "learning", "exercise", "overview", "miracle", "program" };
            Random random = new Random();
            int randomindex = random.Next(0, 8);
            string selectedWord = word[randomindex];
            string hiddenWord = "";
            int amountOfTries = 0;

            for (int i = 0; i < selectedWord.Length; i++)
            {
                hiddenWord += "*";
            }

            //Guessing the random word

            while (hiddenWord.Contains("*"))
            {
                Console.WriteLine($"Word: {hiddenWord}");

                Console.WriteLine("Guess the word by entering a character");
                char letter = char.Parse(Console.ReadLine());
                bool containsLetter = false;

                for (int i = 0; i < selectedWord.Length; i++)
                {

                    if (selectedWord[i] == letter)
                    {
                        hiddenWord = hiddenWord.Remove(i, 1);
                        hiddenWord = hiddenWord.Insert(i, letter.ToString());
                        containsLetter = true;
                    }

                }
                if (containsLetter == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Good choice, the letter '{letter}' is in the hidden word!");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry, the letter '{letter}' is not in the word.");
                }
                Console.ResetColor();
                amountOfTries++;
            }
            Console.Clear();
            //You won
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Congratulations {player}! The word was: {selectedWord} \n Amount of guesses: {amountOfTries}");
            Console.ResetColor();


        }


    }
}