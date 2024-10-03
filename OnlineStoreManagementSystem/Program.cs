using System;
using System.Collections.Generic;
using OnlineStoreManagementSystem.Models;
using OnlineStoreManagementSystem.Services.Discounts;
using OnlineStoreManagementSystem.Services.Payments;

namespace OnlineStoreManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            StoreOwner owner = new StoreOwner();
            Order.OutOfStockEvent += owner.OnProductOutOfStock;

            PhysicalProduct laptop = new PhysicalProduct("Laptop", 1000m, 10);
            DigitalProduct eBook = new DigitalProduct("E-Book", 20m, 100);

            Customer customer = new Customer("John", "Doe");

            IDiscount discount = new PercentageDiscount(10);

            IPayment paymentMethod = new CreditCardPayment();

            List<Product> products = new List<Product> { laptop, eBook };
            Order order = new Order(customer, products, 2, discount, paymentMethod);
            order.ProcessOrder();

            Order anotherOrder = new Order(customer, new List<Product> { laptop }, 10, discount, paymentMethod);
            anotherOrder.ProcessOrder();
        }
    }
}   