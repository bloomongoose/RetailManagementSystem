using CoreBusiness;
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
            //Initializing list with default values
            products = new List<Product>()
            {
                new Product {ProductId = 1, CategoryId = 1, Name = "La Croix", Quantity = 6, Price = 11.99 },
                new Product {ProductId = 2, CategoryId = 1, Name = "Dr. Pepper", Quantity = 12, Price = 9.99 },
                new Product {ProductId = 3, CategoryId = 2, Name = "Lemon Bars", Quantity = 6, Price = 14.99 },
                new Product {ProductId = 4, CategoryId = 2, Name = "Croissants", Quantity = 12, Price = 8.99 },
                new Product {ProductId = 5, CategoryId = 3, Name = "Chicken", Quantity = 6, Price = 15.99 },
                new Product {ProductId = 6, CategoryId = 3, Name = "Turkey", Quantity = 6, Price = 18.99 }
            };
        }

        public void AddProduct(Product product)
        {
            //using Linq to add new category
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

        public void UpdateProduct(Product product)
        {
            var productToUpdate = GetProductById(product.ProductId);
            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.CategoryId = product.CategoryId;
                productToUpdate.Price = product.Price;
                productToUpdate.Quantity = product.Quantity;
            }
        }

        public Product GetProductById(int productId)
        {
            return products.FirstOrDefault(x => x.ProductId == productId);
        }

        public void DeleteProduct(int productId)
        {
            var productToDelete = GetProductById(productId);
            if (productToDelete != null) products.Remove(productToDelete);
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            return products.Where(x => x.CategoryId == categoryId);
        }

    }
}
