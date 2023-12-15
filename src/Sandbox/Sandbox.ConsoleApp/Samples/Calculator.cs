namespace Sandbox.ConsoleApp.Samples
{
    internal class Calculator
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine($"a+b={a + b}");
        }

        public static void Substract(int a, int b)
        {
            Console.WriteLine($"a-b={a + b}");
        }

        public static void Calculate(int a, int b, Action<int, int> operation)
        {
            operation(a, b);
        }
    }
}
