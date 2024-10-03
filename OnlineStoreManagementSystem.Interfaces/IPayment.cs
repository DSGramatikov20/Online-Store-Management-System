namespace OnlineStoreManagementSystem.Services.Payments
{
    public interface IPayment
    {
        void ProcessPayment(decimal amount);
    }
}