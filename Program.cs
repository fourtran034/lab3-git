using System;

namespace Lab3App
{
    internal static class Program
    {
        private static double _a;
        private static double _b;
        private static bool _hasA;
        private static bool _hasB;

        private static void Main()
        {
            while (true)
            {
                PrintMenu();
                Console.Write("Выберите пункт: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": InputA(); break;
                    case "2": InputB(); break;
                    case "3": Add(); break;
                    case "4": Subtract(); break;
                    case "5": Multiply(); break;
                    case "6": Divide(); break;
                    default:
                        Console.WriteLine("Неверный пункт.");
                        break;
                }

                Console.WriteLine();
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("1 - ввести A");
            Console.WriteLine("2 - ввести B");
            Console.WriteLine("3 - выполнить операцию \"+\"");
            Console.WriteLine("4 - выполнить операцию \"-\"");
            Console.WriteLine("5 - выполнить операцию \"*\"");
            Console.WriteLine("6 - выполнить операцию \"/\"");
        }

        private static void InputA()
        {
            Console.WriteLine("Не реализовано.");
        }

        private static void InputB()
        {
            Console.WriteLine("Не реализовано.");
        }

        private static void Add()
        {
            Console.WriteLine("Не реализовано.");
        }

        private static void Subtract()
        {
            Console.WriteLine("Не реализовано.");
        }

        private static void Multiply()
        {
            if (!TryReadOperands()) return;
            Console.WriteLine(_a * _b);
        }

        private static void Divide()
        {
            Console.WriteLine("Не реализовано.");
        }

        private static bool TryReadOperands()
        {
            if (_hasA && _hasB) return true;
            Console.WriteLine("Сначала введите A и B.");
            return false;
        }
    }
}
