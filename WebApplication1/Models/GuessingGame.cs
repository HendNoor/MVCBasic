namespace WebApplication1.Models;

public static class GuessingGame
{
    public static int SecretNum { get; set; }

    public static int attempts = 0;
    public static string GuessNumber(int userGuess, int secretNum)
    {
        string message = "";
        attempts++;
        if (userGuess < 0 || userGuess > 100)
        {
            message = "Invalid guess! Gussed number must be between 1 and 100";
            return message;
        }
        else
        {
            if (userGuess > secretNum)
            {
                message = "Your guess is too high!";
            }
            else if (userGuess < secretNum)
            {
                message = "Your guess is too low!";
            }
            else if (userGuess == secretNum)
            {
                attempts = -1;
                message = "You have guessed the right number! Try guessing the new number";
            }

        }
        return message;

    }
    public static int GenerateNewNumber()
    {
        Random rand = new Random();
        SecretNum = rand.Next(1, 101);
        return SecretNum;
    }
}