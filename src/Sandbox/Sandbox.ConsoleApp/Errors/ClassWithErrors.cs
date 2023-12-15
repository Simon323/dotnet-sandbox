namespace Sandbox.ConsoleApp.Errors
{
    internal class ClassWithErrors
    {
        public int GetLastOrderId()
        {
            var orders = new int[] { 243, 53, 545 };
            return orders[3];
        }
    }
}
