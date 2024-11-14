using System;

namespace ExampleWithWarnings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Попередження: невикористовувана змінна
            int unusedVariable = 42;

            // Попередження: неявне приведення типів
            double number = 10.5;
            int result = AddNumbers(5, (int)number); // Явне приведення типу

            Console.WriteLine("Result: " + result);

            // Попередження: метод не використовується
            PrintMessage("This is a test message");
        }

        // Метод, який додає два числа
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        // Метод, який виводить повідомлення
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}