namespace Sandbox.ConsoleApp.Samples
{
    internal class ClassWithResources : IDisposable
    {
        public ClassWithResources()
        {
            Console.WriteLine("Open DB connection");
        }

        public void Dispose()
        {
            Console.WriteLine("Close DB connection");
        }
    }
}
