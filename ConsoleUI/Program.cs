// See https://aka.ms/new-console-template for more information
using Business;
using DataAccess;
using System;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService productService = new ProductService(new EfProductDal());

            foreach (var product in productService.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            try
            {
                productService.Add(new Entities.Product { ProductId = 2, ProductName = "Laptop", QuantityPerUnit = "i7 işlemcili" });
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            
        }
    }
}
