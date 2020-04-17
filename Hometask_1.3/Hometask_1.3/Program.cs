using System;

namespace Hometask3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2;

            Console.WriteLine("Введите первое число:");
            x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите необходимую операцию: + , - , * , /.");
            string key = Console.ReadLine();

            switch (key)
            {
                case "+":
                    {
                        Console.WriteLine("Результат вычислений: {0} {1} {2} = {3}", x1, key, x2, (x1 + x2).ToString("0.00"));
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine("Результат вычислений: {0} {1} {2} = {3}", x1, key, x2, (x1 - x2).ToString("0.00"));
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine("Результат вычислений: {0} {1} {2} = {3}", x1, key, x2, (x1 * x2).ToString("0.00"));
                        break;
                    }
                case "/":
                    {
                        if (x2 != 0)
                        {
                            Console.WriteLine("Результат вычислений: {0} {1} {2} = {3}", x1, key, x2, (x1 / x2).ToString("0.00"));
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: Деление на 0!");
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка: Введена некорректная операция!");
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
