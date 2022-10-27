class Program
{
    static void Main(string[] args)
    {
        Calculate sum = new Calculate();
        Calculate calculate = new Calculate();

        Logger error = new Logger();
        Logger eve = new Logger();

        try
        {  
            calculate.Input();
            double a = Convert.ToDouble(Console.ReadLine());

            calculate.Input();
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Сумма равна {sum.Sum(a, b)}");

            eve.Event("Готово!");

        }
        catch (FormatException)
        {
            error.Error("Ошибка!");
        }
    }
}
class Calculate : ICalculate
{
    public void Input()
    {
        Console.WriteLine("Введите число: ");
        
    }
    public double Sum (double a, double b)
    {
        return a + b;
    }
}
public interface ICalculate
{
    void Input();
    double Sum(double a, double b);
}
class Logger : ILogger
{
    public void Error(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
    }
    public void Event(string message)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine(message);
    }
}
public interface ILogger
{
    void Error(string message);
    void Event(string message);
}