namespace Sandbox.ConsoleApp.Samples
{
    internal class LocalMethod
    {
        public LocalMethod()
        {
        }

        public void Run()
        {
            Step1();
            Step2();

            void Step1()
            {
                Console.WriteLine("Step 1");
            }

            void Step2()
            {
                Console.WriteLine("Step 2");
            }
        }
    }
}
