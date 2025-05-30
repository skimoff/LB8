namespace LB8.Task3;

public class LambdaFunc
{
    public static Func<int[], int> CountMultiplesOfSeven = 
        arr => arr.Count(n => n % 7 == 0 && n != 0);

    public static Func<int[], int> CountPositiveNumbers = 
        arr => arr.Count(n => n > 0);

    public static Predicate<DateTime> IsProgrammerDay = 
        date => date.DayOfYear == 256;

    public static Func<string, string[], bool> ContainsWords = 
        (text, words) => words.Any(word => text.Contains(word, StringComparison.OrdinalIgnoreCase));
}
