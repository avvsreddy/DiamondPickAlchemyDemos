using ProductCatalogManagement.DataAccess;
using ProductCatalogManagement.Entities;
using System;
using System.Linq;

namespace ProductCatalogManagement
{
    internal class Program // UI Layer
    {
        static void Main(string[] args)
        {
            // Manage Products - CRUD
            // Development Approach
            // 1. Code First
            // 2. DB First


            // What information?
            // Create Entity Classess

            // Add new product - Write only OO Code

            //SaveProduct();
            //ShowAllProducts();
            //DeleteProduct();
            EditProduct();
        }


        private static void EditProduct()
        {
            // increase product 1 cost to 1000
            ProductsCatalogDbContext db = new ProductsCatalogDbContext();
            var productToEdit = db.Products.Find(1);
            productToEdit.Cost += 1000;
            db.SaveChanges();
            Console.WriteLine("Product modified");
        }
        private static void DeleteProduct()
        {
            ProductsCatalogDbContext db = new ProductsCatalogDbContext();
            Console.Write("Enter product id to delete :");
            int id = int.Parse(Console.ReadLine());
            var productToDel = db.Products.Find(id);
            if (productToDel == null)
                Console.WriteLine("No such product found....");
            else
            {
                db.Products.Remove(productToDel);
                db.SaveChanges();
                Console.WriteLine("Product deleted....");
            }
        }

        private static void ShowAllProducts()
        {
            ProductsCatalogDbContext db = new ProductsCatalogDbContext();
            var plist = db.Products.ToList();
            foreach (var item in plist)
            {
                Console.WriteLine(item.ProductId +"\t" + item.Name + "\t" + item.Cost + "\t"+item.IsInStock);
            }
        }

        private static void SaveProduct()
        {
            ProductsCatalogDbContext db = new ProductsCatalogDbContext();
            Product p = new Product();
            Console.Write("Enter Product Name: ");
            p.Name = Console.ReadLine();
            Console.Write("Enter the Product Cost: ");
            p.Cost = int.Parse(Console.ReadLine());
            Console.Write("Is In Stock: ");
            p.IsInStock = bool.Parse(Console.ReadLine());
            //Product p = new Product { Name = "IPhone X", Cost = 89000, IsInStock = true };
            db.Products.Add(p);
            db.SaveChanges();
            Console.WriteLine("Product saved....");
        }
    }
}
