using HW5_ShayanMadahi_m97.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW5_ShayanMadahi_m97.Interface
{
    public class ProductRepository : IProductRepository
    {
       private List<Product> products;
        private bool Test;
       // private string FilePath;

        public ProductRepository()
        {
            string? solutionFolderPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName;
            string solutionPath = Path.Combine(solutionFolderPath, "DataBase");
            string FilePath = Path.Combine(solutionPath, "ProductJson.json");
            FileStream JsonProductFile = File.Open(FilePath, FileMode.OpenOrCreate);

            products = JsonSerializer.Deserialize<List<Product>>(JsonProductFile);
        }
        public string AddProduct(Product product)
        {
            CheckName(product.Name);
            if (Test)
            {
                products.Add(product);
                JsonWriter();
            }

            return "ok";
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
            Test= regex.IsMatch(productname);
            if (!Test)
                Console.WriteLine("Not corect!!");
            return Test;
            
        }
        private void JsonWriter()
        {
            string? solutionFolderPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName;
            string solutionPath = Path.Combine(solutionFolderPath, "DataBase");
            string FilePath = Path.Combine(solutionPath, "ProductJson.json");
            string jsonSerialize=JsonSerializer.Serialize(products);
            File.WriteAllText(FilePath, jsonSerialize);
        }
    }
}
