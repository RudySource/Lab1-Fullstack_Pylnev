namespace MyNamespace;

internal static class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("\nВведите Имя: ");
            Console.WriteLine($"Привет, {Console.ReadLine()}\n{DateTime.Now}\nХотите продолжить? (y/n): ");
            switch (Console.ReadLine()?.ToLower())
            {
                case "y":
                    continue;
                case "n":
                    Console.WriteLine("Завершение программы...");
                    return;
                default:
                    Console.WriteLine("Ошибка ввода!\n");
                    break;
            }
        } //P.S Могу сделать через try catch ради интереса.
    } 
}

