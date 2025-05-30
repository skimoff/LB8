namespace LB8.Task1;

public class NumberUtilities
{
    public static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i * i <= n; i++)
            if (n % i == 0) return false;
        return true;
    }

    public static bool IsFibonacci(int number)
    {
        bool IsPerfectSquare(int x)
        {
            int s = (int)Math.Sqrt(x);
            return s * s == x;
        }

        return IsPerfectSquare(5 * number * number + 4) ||
               IsPerfectSquare(5 * number * number - 4);
    }
}