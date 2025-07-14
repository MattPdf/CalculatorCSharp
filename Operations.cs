using Microsoft.VisualBasic;

public class Operations
{
    public static double Sum(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiplication(double a, double b)
    {
        return a * b;
    }

    public static double Division(double a, double b)
    {
        if (b == 0 || a == 0)
        {
            Console.WriteLine("You cant divide 0");
            return double.NaN;
        }
        return a / b;
    }
}
