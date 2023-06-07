using HW5_ShayanMadahi_m97.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW5_ShayanMadahi_m97.Interface
{
    public class ProductRepository : IProductRepository
    {
        public string AddProduct(Product product)
        {
            CheckName(product.Name);

            return "okk";
        }

        public string GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductList()
        {
            throw new NotImplementedException();
        }

        private bool CheckName(string productname)
        {
            
            Regex regex = new Regex(@"^[A-Z][a-z]{3}[1-9]{1}[_]{1}[1-9]{2}$");
            bool Test= regex.IsMatch(productname);
            if (!Test)
                Console.WriteLine("Not corect!!");
            return Test;
            
        }
    }
}
