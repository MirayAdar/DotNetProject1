using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    internal interface IProductService
    {
        List<Product> GetAll();
        void Add(Product product);

    }
}
