namespace Lib.ProblemSolving;

public static class Challenge1
{
    public static Challenge1Result FractionsCalculator(int[] numbers)
    {
        decimal count = numbers.Length;

        return new Challenge1Result()
        {
            Positives = Math.Round(numbers.Where(x => x > 0).Count() / count, 6),
            Negatives = Math.Round(numbers.Where(x => x < 0).Count() / count, 6),
            Zeros = Math.Round(numbers.Where(x => x == 0).Count() / count, 6),
        };
    }
}

public class Challenge1Result
{
    public decimal Positives { get; set; }
    public decimal Negatives { get; set; }
    public decimal Zeros { get; set; }
}