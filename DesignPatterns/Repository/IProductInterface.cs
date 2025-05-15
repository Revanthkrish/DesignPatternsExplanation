using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product1> GetAll();
        Product1 GetById(int id);
        void Add(Product1 product);
        void Update(Product1 product);
        void Delete(int id);
    }
}
