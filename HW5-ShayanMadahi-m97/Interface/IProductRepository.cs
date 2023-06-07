using HW5_ShayanMadahi_m97.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_ShayanMadahi_m97.Interface
{
    public interface IProductRepository
    {
        string AddProduct(Product product);
        List<Product> GetProductList();
        string GetProductById(int id);

    }
}
