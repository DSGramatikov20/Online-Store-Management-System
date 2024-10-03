using System;
using System.Collections.Generic;
using OnlineStoreManagementSystem.Services.Discounts;
using OnlineStoreManagementSystem.Services.Payments;

namespace OnlineStoreManagementSystem.Models
{
    public class Order
    {
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
        public int Quantity { get; set; }
        public IDiscount Discount { get; set; }
        public IPayment PaymentMethod { get; set; }

        public Order(Customer customer, List<Product> products, int quantity, IDiscount discount, IPayment paymentMethod)
        {
            Customer = customer;
            Products = products;
            Quantity = quantity;
            Discount = discount;
            PaymentMethod = paymentMethod;
        }

        public void ProcessOrder()
        {
            Customer.DisplayCustomerInfo();
            foreach (var product in Products)
            {
                Console.WriteLine($"Processing order for {product.Name}");

                if (product.CheckStock(Quantity))
                {
                    decimal total = product.Price * Quantity;

                    if (Discount != null)
                    {
                        total = Discount.ApplyDiscount(total);
                        Console.WriteLine($"Discount applied. New total: {total:C}");
                    }

                    PaymentMethod.ProcessPayment(total);

                    product.DeductStock(Quantity);

                    if (product.Stock == 0)
                    {
                        OnProductOutOfStock(product);
                    }
                }
                else
                {
                    Console.WriteLine($"Insufficient stock for {product.Name}. Available stock: {product.Stock}");
                }
            }
        }

        public static event Action<Product> OutOfStockEvent;

        protected virtual void OnProductOutOfStock(Product product)
        {
            Console.WriteLine($"Product {product.Name} is out of stock.");
            OutOfStockEvent?.Invoke(product);
        }
    }
}
