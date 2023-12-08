
public class Program
{
    public static void Main()
    {
        Calculator calculator = new Calculator();


        calculator.Calculate += PlusNumbers;
        calculator.Calculate += MultiplyNumbers;


        int result = CalculateWithExceptionHandler(calculator, 5, 3);
        Console.WriteLine("Результат: " + result);
    }

    public static int CalculateWithExceptionHandler(Calculator calculator, int a, int b)
    {
        try
        {
            return ExecuteCalculation(calculator, a, b);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
            return 0;
        }
    }

    public static int ExecuteCalculation(Calculator calculator, int a, int b)
    {
        return calculator.Sum(a, b);
    }

    public static int PlusNumbers(int a, int b)
    {
        return a + b;
    }

    public static int MultiplyNumbers(int a, int b)
    {
        return a * b;
    }
}
public delegate int CalculateDelegate(int a, int b);

public class Calculator
{
    public event CalculateDelegate Calculate;

    public int Sum(int a, int b)
    {
        if (Calculate != null)
            return Calculate(a, b);
        return 0;
    }
}