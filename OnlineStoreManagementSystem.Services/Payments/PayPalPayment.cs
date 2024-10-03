namespace OnlineStoreManagementSystem.Services.Payments
{
    public class PayPalPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount:C}");
        }
    }
}