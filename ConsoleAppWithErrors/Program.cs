using System;

namespace ExampleWithErrors
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Синтаксична помилка: пропущена дужка
            Console.WriteLine("This is a test message";

            // Логічна помилка: неправильне використання змінної
            int result = AddNumbers(5, "10"); // Спроба передати рядок замість цілого числа

            Console.WriteLine("Result: " + result);
        }

        // Метод, який додає два числа
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}