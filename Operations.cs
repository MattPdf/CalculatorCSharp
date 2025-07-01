public class Operations
{
    public static double Sum(double a, double b)
    {
        return a + b;
    }

    public static double Restar(double a, double b)
    {
        return a - b;
    }

    public static double Mult(double a, double b)
    {
        return a * b;
    }

    public static double Division(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("No se puede dividir por cero.");
            return double.NaN;
        }
        return a / b;
    }
}
