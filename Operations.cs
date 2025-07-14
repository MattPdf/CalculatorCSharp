using Microsoft.VisualBasic;

public class Operations
{
    public static (int, int) AddNum()
    {
        Console.WriteLine("Please, select the first number");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please, select the second number");
        int n2 = Convert.ToInt32(Console.ReadLine());

        return (n1, n2);
    }


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
