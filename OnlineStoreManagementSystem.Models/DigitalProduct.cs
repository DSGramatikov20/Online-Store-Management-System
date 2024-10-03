namespace OnlineStoreManagementSystem.Models
{
    public class DigitalProduct : Product
    {
        public DigitalProduct(string name, decimal price, int stock) : base(name, price, stock) { }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Digital Product: {Name}, Price: {Price:C}, Stock: {Stock}");
        }

        // Digital products don't require stock deduction
        public override void DeductStock(int quantity)
        {
            Console.WriteLine($"{Name} is a digital product, no stock management required.");
        }
    }
}