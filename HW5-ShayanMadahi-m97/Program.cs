using HW5_ShayanMadahi_m97.Domain;
using HW5_ShayanMadahi_m97.Interface;

namespace HW5_ShayanMadahi_m97
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product=new Product();
            ProductRepository repository=new ProductRepository();
            product.Name = "Aele1_86";
            product.ProductId = 1;
            product.Barcode = "1";
            repository.AddProduct(product);

        }
    }
}