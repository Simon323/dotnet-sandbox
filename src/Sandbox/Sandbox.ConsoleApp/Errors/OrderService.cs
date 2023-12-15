namespace Sandbox.ConsoleApp.Errors
{
    internal class OrderService
    {
        public int GetLastOrderId()
        {
            try
            {
                var lastOrderId = new ClassWithErrors()
                    .GetLastOrderId();
                return lastOrderId;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SignOrder(int orderId, string signatureId)
        {
            // signing code here...
            throw new OrderSignException("Can't sign", orderId, "INVALID");
        }
    }
}
