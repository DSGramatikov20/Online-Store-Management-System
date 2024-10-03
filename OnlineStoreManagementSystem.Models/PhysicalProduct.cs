namespace OnlineStoreManagementSystem.Models
{
    public class PhysicalProduct : Product
    {
        public PhysicalProduct(string name, decimal price, int stock) : base(name, price, stock) { }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Physical Product: {Name}, Price: {Price:C}, Stock: {Stock}");
        }
    }
}