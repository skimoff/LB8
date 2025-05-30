namespace LB8.Task3;

public class LambdaFunc
{
    // Підрахунок чисел, кратних семи
    public static Func<int[], int> CountMultiplesOfSeven = 
        arr => arr.Count(n => n % 7 == 0 && n != 0);

    // Підрахунок позитивних чисел
    public static Func<int[], int> CountPositiveNumbers = 
        arr => arr.Count(n => n > 0);

    // Перевірка, чи є день програміста (256-й день року)
    public static Predicate<DateTime> IsProgrammerDay = 
        date => date.DayOfYear == 256;

    // Перевірка на наявність заданого(их) слова(слів) у тексті
    public static Func<string, string[], bool> ContainsWords = 
        (text, words) => words.Any(word => text.Contains(word, StringComparison.OrdinalIgnoreCase));
}