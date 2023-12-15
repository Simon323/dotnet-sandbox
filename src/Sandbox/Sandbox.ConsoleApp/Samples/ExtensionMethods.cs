namespace Sandbox.ConsoleApp.Samples
{
    internal static class ExtensionMethods
    {
        public static double CalsiusToFahrenheit(this double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}
