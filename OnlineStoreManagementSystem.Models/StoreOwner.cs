namespace OnlineStoreManagementSystem.Models
{
    public class StoreOwner
    {
        public void OnProductOutOfStock(Product product)
        {
            Console.WriteLine($"Alert: {product.Name} is out of stock!");
        }
    }
}