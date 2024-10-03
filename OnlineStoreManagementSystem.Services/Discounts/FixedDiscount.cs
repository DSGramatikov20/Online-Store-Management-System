namespace OnlineStoreManagementSystem.Services.Discounts
{
    public class FixedDiscount : IDiscount
    {
        private decimal discountAmount;

        public FixedDiscount(decimal discountAmount)
        {
            this.discountAmount = discountAmount;
        }

        public decimal ApplyDiscount(decimal price)
        {
            return price - discountAmount;
        }
    }
}