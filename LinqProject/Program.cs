using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Bilgisayar"},
                new Category{CategoryId=2,CategoryName="Telefon"},
                new Category{CategoryId=3,CategoryName="Beyaz Eşya"}
            };
            List<Product> products = new List<Product> { 
                new Product { ProductId = 1, CategoriId = 1, ProductName = "Acer Laptop", QuantityPerUnit = "32 GB RAM", UnitPrice = 30000, UnitsInStock = 5 },
            new Product { ProductId = 1, CategoriId = 1, ProductName = "Asus Laptop", QuantityPerUnit = "32 GB RAM", UnitPrice = 35000, UnitsInStock = 3 },
            new Product { ProductId = 2, CategoriId = 1, ProductName = "HP Laptop", QuantityPerUnit = "32 GB RAM", UnitPrice = 40000, UnitsInStock = 2 },
            new Product { ProductId = 4, CategoriId = 2, ProductName = "Samsung", QuantityPerUnit = "4 GB RAM", UnitPrice = 19000, UnitsInStock = 0 },
            new Product { ProductId = 5, CategoriId = 2, ProductName = "Apple", QuantityPerUnit = "4 GB RAM", UnitPrice = 15000, UnitsInStock = 5 }
            };

            GetProducts(products);
            Console.WriteLine("-----------------");
            GetProductsLinq(products);
            Console.ReadKey();
        }
        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 20000)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 20000).ToList();
        }
    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoriId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
