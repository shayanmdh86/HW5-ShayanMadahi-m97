using HW5_ShayanMadahi_m97.Domain;
using HW5_ShayanMadahi_m97.Interface;

namespace HW5_ShayanMadahi_m97
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string Name = "Tele1_23";
           int ProductId = 1;
           string Barcode = "1";
            Product product = new Product(ProductId, Name, Barcode);
            ProductRepository repository=new ProductRepository();
            repository.AddProduct(product);

        }
    }
}