using LB8.Task1;
using LB8.Task2;
using LB8.Task3;

namespace LB8;

class Program
{
    static void Task1()
    {
        Action showTime = DateUtilities.ShowCurrentTime;
        Action showDate = DateUtilities.ShowCurrentDate;
        Action showDay = DateUtilities.ShowCurrentDayOfWeek;

        showTime();
        showDate();
        showDay();

        // === Predicate ===
        Predicate<int> isPrime = NumberUtilities.IsPrime;
        Predicate<int> isFibonacci = NumberUtilities.IsFibonacci;

        int number = 21;
        Console.WriteLine($"\n{number} — просте число? {isPrime(number)}");
        Console.WriteLine($"{number} — число Фібоначчі? {isFibonacci(number)}");

        // === Func ===
        Func<double, double, double, double> triangleArea = GeometryUtilities.GetTriangleArea;
        Func<double, double, double> rectangleArea = GeometryUtilities.GetRectangleArea;
        Func<double, double, double> rectanglePerimeter = GeometryUtilities.GetRectanglePerimeter;

        Console.WriteLine($"\nПлоща трикутника (3, 4, 5): {triangleArea(3, 4, 5)}");
        Console.WriteLine($"Площа прямокутника 4 x 7: {rectangleArea(4, 7)}");
        Console.WriteLine($"Периметр прямокутника 4 x 7: {rectanglePerimeter(4, 7)}");
    }

    static void Task2()
    {
        // Створюємо валізу
        Suitcase suitcase = new Suitcase("Чорна", "Samsonite", 3.5, 30.0);

        // Підписка на подію
        suitcase.ItemAdded += item =>
        {
            Console.WriteLine($"Додано об'єкт: {item.Name} (об'єм: {item.Volume} л)");
        };

        // Створюємо предмети
        LuggageItem item1 = new LuggageItem("Фен", 5);
        LuggageItem item2 = new LuggageItem("Кросівки", 7);
        LuggageItem item3 = new LuggageItem("Ноутбук", 15);
        LuggageItem item4 = new LuggageItem("Книга", 10); // перевищить об'єм

        try
        {
            suitcase.AddItem(item1);
            suitcase.AddItem(item2);
            suitcase.AddItem(item3);
            suitcase.AddItem(item4); // тут буде виняток
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }

        // Вивід вмісту
        suitcase.ShowContents();
    }

    static void Task3()
    {
        int[] numbers = { 7, 14, -3, 0, 21, 5, 9, 28, -7, 1, 2, 3 };
        Console.WriteLine("Масив: " + string.Join(", ", numbers));
        Console.WriteLine("Кратних 7: " + LambdaFunc.CountMultiplesOfSeven(numbers));
        Console.WriteLine("Позитивних: " + LambdaFunc.CountPositiveNumbers(numbers));

        DateTime d1 = new DateTime(2024, 9, 12); // високосний рік
        DateTime d2 = new DateTime(2023, 9, 13); // не високосний
        Console.WriteLine($"\n{d1.ToShortDateString()} — день програміста? {LambdaFunc.IsProgrammerDay(d1)}");
        Console.WriteLine($"{d2.ToShortDateString()} — день програміста? {LambdaFunc.IsProgrammerDay(d2)}");

        string text = "Цей текст містить слово програмування та технології.";
        string[] searchWords = { "код", "алгоритм", "програмування" };
        Console.WriteLine($"\nТекст: {text}");
        Console.WriteLine("Містить ключові слова? " + LambdaFunc.ContainsWords(text, searchWords));
    }
    
    static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Console.ReadKey();
    }
}