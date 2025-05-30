namespace LB8.Task1;

public class GeometryUtilities
{
    public static double GetTriangleArea(double a, double b, double c)
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    public static double GetRectangleArea(double width, double height) =>
        width * height;

    public static double GetRectanglePerimeter(double width, double height) =>
        2 * (width + height);
}