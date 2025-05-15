using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Repository
{
    public class ProductRepository:IProductRepository
    {
        private readonly List<Product1> _products = new List<Product1>();

        public IEnumerable<Product1> GetAll()
        {
            return _products;
        }

        public Product1 GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public void Add(Product1 product)
        {
            _products.Add(product);
        }

        public void Update(Product1 product)
        {
            var existing = GetById(product.Id);
            if (existing != null)
            {
                existing.Name = product.Name;
                existing.Price = product.Price;
            }
        }

        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }
}
