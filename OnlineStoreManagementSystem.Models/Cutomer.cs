namespace OnlineStoreManagementSystem.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void DisplayCustomerInfo()
        {
            Console.WriteLine($"Customer: {FirstName} {LastName}");
        }
    }
}