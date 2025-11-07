// Author: Nsikak Eyo
// Represents an order containing customer and list of products

using System;
using System.Collections.Generic;

namespace NsikakOrdering
{
    public class Order
    {
        private Customer _orderCustomer;
        private List<Product> _orderProducts;

        public Order(Customer customer)
        {
            _orderCustomer = customer;
            _orderProducts = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _orderProducts.Add(product);
        }

        public double TotalPrice()
        {
            double sum = 0;
            foreach (var p in _orderProducts)
            {
                sum += p.TotalCost();
            }
            sum += _orderCustomer.LivesInUSA() ? 5 : 35;
            return sum;
        }

        public string PackingLabel()
        {
            string label = "📦 Packing Label:\n";
            foreach (var p in _orderProducts)
            {
                label += p.ProductInfo() + "\n";
            }
            return label;
        }

        public string ShippingLabel()
        {
            return $"🚚 Shipping Label:\n{_orderCustomer.Name}\n{_orderCustomer.Address.FullAddress()}";
        }
    }
}
