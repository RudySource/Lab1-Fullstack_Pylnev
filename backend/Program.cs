namespace MyNamespace;

internal static class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите Имя: ");
            Console.WriteLine($"Привет, {Console.ReadLine()}\n{DateTime.Now}\nХотите продолжить? (y/n): ");
            if (Console.ReadLine() == "n") break;
        }
    } 
}