namespace Sandbox.ConsoleApp.Errors
{
    internal class OrderSignException : Exception
    {
        public OrderSignException() { }
        public OrderSignException(string message)
            : base(message) { }
        public OrderSignException(string message, Exception inner)
            : base(message, inner) { }
        public OrderSignException(string message, int orderId, string signErrorCode)
            : base(message)
        {
            OrderId = orderId;
            SignErrorCode = signErrorCode;
        }

        public int OrderId { get; private set; }
        public string SignErrorCode { get; private set; }
    }
}
