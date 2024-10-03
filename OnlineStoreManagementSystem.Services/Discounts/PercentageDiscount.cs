namespace OnlineStoreManagementSystem.Services.Discounts
{
    public class PercentageDiscount : IDiscount
    {
        private decimal percentage;

        public PercentageDiscount(decimal percentage)
        {
            this.percentage = percentage;
        }

        public decimal ApplyDiscount(decimal price)
        {
            return price - (price * percentage / 100);
        }
    }
}