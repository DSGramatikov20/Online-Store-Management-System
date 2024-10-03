namespace OnlineStoreManagementSystem.Models
{
    public abstract class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Product(string name, decimal price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public abstract void DisplayDetails();

        public virtual bool CheckStock(int quantity)
        {
            return Stock >= quantity;
        }

        public virtual void DeductStock(int quantity)
        {
            Stock -= quantity;
        }
    }
}