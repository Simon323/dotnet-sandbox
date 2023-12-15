namespace Sandbox.ConsoleApp.Samples
{
    internal class PersonalInformation
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }

    internal static class ClassVsTuple
    {
        public static PersonalInformation GetPersonalInfo()
        {
            return new PersonalInformation
            {
                Name = "John Doe",
                Age = 32
            };
        }

        public static (string Name, int Age) GetPersonaInfoAsTupel()
        {
            return ("John Doe", 32);
        }
    }
}
