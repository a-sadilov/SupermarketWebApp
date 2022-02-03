﻿using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private List<Product> products;
        public ProductInMemoryRepository()
        {
            //Initialise with default values
            products = new List<Product>()
            {
                new Product { ProductId = 1, CategoryId = 1, Name = "Ice Tee", Quantity = 100, Price=79.99 },
                new Product { ProductId = 2, CategoryId = 1, Name = "Fanta", Quantity = 100, Price=89.99 },
                new Product { ProductId = 3, CategoryId = 2, Name = "Cheese Cake", Quantity = 20, Price=119.99 },
                new Product { ProductId = 4, CategoryId = 2, Name = "Apple-Sharlotte", Quantity = 20, Price=99.99 },
                new Product { ProductId = 5, CategoryId = 3, Name = "Parmesan", Quantity = 30, Price=369.99 },
                new Product { ProductId = 6, CategoryId = 3, Name = "Lambert", Quantity = 50, Price=259.99 },
            };
        }

        public void AddProduct(Product product)
        {
            if (products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (products != null && products.Count > 0)
            {
                var maxId = products.Max(x => x.ProductId);
                product.ProductId = maxId + 1;
            }
            else
            {
                product.ProductId = 1;
            }
            products.Add(product);
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
