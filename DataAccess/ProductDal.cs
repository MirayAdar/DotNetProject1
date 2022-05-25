using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDal: IProductDal
    {
        //Ado.Net
        List<Product> _products;

        public ProductDal()
        {
            _products = new List<Product> { 
            new Product {ProductId = 1, ProductName="Samsung Tv", QuantityPerUnit="98 Ekran", UnitPrice=8000, UnitsInStock= 2},
            new Product {ProductId = 2, ProductName="Vestel Tv", QuantityPerUnit="98 Ekran", UnitPrice=9000, UnitsInStock= 1},
            new Product {ProductId = 3, ProductName="Toshiba Tv", QuantityPerUnit="98 Ekran", UnitPrice=10000, UnitsInStock= 0},
            new Product {ProductId = 4, ProductName="Grundig Tv", QuantityPerUnit="98 Ekran", UnitPrice=15000, UnitsInStock= 3},
            };
        }

        public void Add(Product product)
        {
            Console.WriteLine("Ado.NET ile eklendi");
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
