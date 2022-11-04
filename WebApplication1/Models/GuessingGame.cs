namespace WebApplication1.Models
{
    public class GuessingGame
    {
        public bool IsCorrect { get; set; } = false;
        public string IsCorrectNo(int guess, int secretNo)
        {
            if (guess > secretNo)
            {
                return "Your guess was greater than the target";
            }
            else if (guess < secretNo)
            {
                return "Your guess was lesser than the target";
            }

            IsCorrect = true;
            return "Your guess was correct. Congratulations! Guess again";
        }
    }
}
