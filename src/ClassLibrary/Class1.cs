namespace ExampleWithWarnings
{
    public static class Program
    { static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Попередження: невикористовувана змінна
            int unusedVariable = 42;

            // Попередження: неявне приведення типів
            double number = 10.5;
            int result = AddNumbers(5.2, (int)number); // Явне приведення типу

            Console.WriteLine("Result: " + result);
        }
        
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}