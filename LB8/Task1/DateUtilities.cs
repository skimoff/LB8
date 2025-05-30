namespace LB8.Task1;

public class DateUtilities
{
    public static void ShowCurrentTime()
    {
        Console.WriteLine("Час: " + DateTime.Now.ToLongTimeString());
    }

    public static void ShowCurrentDate()
    {
        Console.WriteLine("Дата: " + DateTime.Now.ToShortDateString());
    }

    public static void ShowCurrentDayOfWeek()
    {
        Console.WriteLine("День тижня: " + DateTime.Now.DayOfWeek);
    }
}