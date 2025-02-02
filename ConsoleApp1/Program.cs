using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;
        try
        {
            Console.WriteLine("Введіть число a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть число b:");
            double b = Convert.ToDouble(Console.ReadLine());

            double sum = a + b;

            Console.WriteLine($"\nСума чисел: {sum}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Помилка.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
        finally
        {
            Console.ReadKey();
        }
    }
}

