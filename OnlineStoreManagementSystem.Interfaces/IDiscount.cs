namespace OnlineStoreManagementSystem.Services.Discounts
{
    public interface IDiscount
    {
        decimal ApplyDiscount(decimal price);
    }
}