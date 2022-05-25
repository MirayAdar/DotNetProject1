using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ProductService:IProductService
    {
        // İş kodları yazılır.
        IProductDal _productDal;

        public ProductService(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {

            if (product.ProductName == "Laptop")
            {
                throw new Exception("Laptop Ekleyemezsiniz.");
            }
                _productDal.Add(product);
            
        }

        public List<Product> GetAll()
        {
           

            return _productDal.GetAll();


        }
    }
}
