using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using InventoryApp.Models;

namespace InventoryApp.Data
{
    public class ProductRepository
    {
        private readonly string filePath = "products.json";
        private List<Product> products = new List<Product>();
        private int nextId = 1;

        public ProductRepository()
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                products = JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
                if (products.Any()) nextId = products.Max(p => p.Id) + 1;
            }
        }

        private void Save() => File.WriteAllText(filePath, JsonSerializer.Serialize(products));

        public List<Product> GetAll() => products.ToList();

        public void Add(Product product)
        {
            product.Id = nextId++;
            products.Add(product);
            Save();
        }

        public void Update(Product product)
        {
            var existing = products.FirstOrDefault(p => p.Id == product.Id);
            if (existing != null)
            {
                existing.Name = product.Name;
                existing.Category = product.Category;
                existing.Price = product.Price;
                existing.Quantity = product.Quantity;
                Save();
            }
        }

        public void Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                products.Remove(product);
                Save();
            }
        }

        public List<Product> Search(string query) => products
            .Where(p => p.Name.ToLower().Contains(query.ToLower()))
            .ToList();
    }
}
