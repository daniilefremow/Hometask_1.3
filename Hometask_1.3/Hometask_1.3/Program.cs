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
                        Out(x1, key, x2, Add(x1, x2).ToString("0.00"));
                        break;
                    }
                case "-":
                    {
                        Out(x1, key, x2, Sub(x1, x2).ToString("0.00"));
                        break;
                    }
                case "*":
                    {
                        Out(x1, key, x2, Mult(x1, x2).ToString("0.00"));
                        break;
                    }
                case "/":
                    {
                        if (x2 != 0)
                        {
                            Out(x1, key, x2, Div(x1, x2).ToString("0.00"));
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

        public static double Mult (double x1, double x2)
        {
            return x1 * x2;
        }

        public static double Div (double x1, double x2)
        {
            return x1 / x2;
        }

        public static double Add (double x1, double x2)
        {
            return x1 + x2;
        }

        public static double Sub (double x1, double x2)
        {
            return x1 - x2;
        }

        public static void Out(double x1, string str1, double x2, string str2)
        {
            Console.WriteLine("Результат вычислений: {0} {1} {2} = {3}", x1, str1, x2, str2);
        }
    }
}
