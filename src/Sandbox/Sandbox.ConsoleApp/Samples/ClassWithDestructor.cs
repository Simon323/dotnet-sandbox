namespace Sandbox.ConsoleApp.Samples
{
    public class ClassWithDestructor
    {
        public string Name { get; set; }

        public ClassWithDestructor()
        {
            Name = RandomStringGenerator.GenerateString(10000);
            Console.WriteLine("Object Created");
        }

        ~ClassWithDestructor()
        {
            Console.WriteLine("Object destructed");
        }
    }
}
