namespace Sandbox.ConsoleApp.Samples
{
    internal static class ParamsSample
    {
        public static void DisplayNames(params string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
