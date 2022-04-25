using Microsoft.EntityFrameworkCore;
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
            ProductsCatalogDbContext db = new ProductsCatalogDbContext();
            // get all customers

            var customers = db.Customers.ToList();
            foreach (var item in customers)
            {
                Console.WriteLine(item.Name);
            }

        }

        private static void NewMethod2(ProductsCatalogDbContext db)
        {
            // Add new customer and new supplier
            var cust = new Customer { Name = "Customer 1", Discount = 6.5 };
            var supp = new Supplier { Name = "Supplier 1", Rating = 4 };

            db.People.Add(cust);
            db.People.Add(supp);
            db.SaveChanges();
        }

        private static void NewMethod1(ProductsCatalogDbContext db)
        {
            // Add two new products with one new supplier with one new category
            var s = new Supplier { Name = "Supplier 1" };
            var c = new Category { Name = "Laptops" };
            var p1 = new Product { Name = "Dell XPS 123" };
            var p2 = new Product { Name = "HP Pavilion 123" };
            p1.Category = c;
            p2.Category = c;
            p1.Suppliers.Add(s);
            p2.Suppliers.Add(s);
            db.Products.Add(p1);
            db.Products.Add(p2);
            db.SaveChanges();
        }

        private static void NewMethod(ProductsCatalogDbContext db)
        {
            // Get all products belongs to Smart Watch category
            // case 1

            var products = from c in db.Categories
                           where c.Name == "Smart Watch"
                           select c.Products;


            foreach (var c in products)
            {
                foreach (var item in c)
                {
                    Console.WriteLine(item.Name);
                }
            }

            // case 2

            Console.WriteLine("Case 2 ================");

            var plist = from p in db.Products
                        where p.Category.Name == "Smart Watch"
                        select p;

            foreach (var item in plist)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void GetProductsIncludeCategory()
        {
            ProductsCatalogDbContext db = new ProductsCatalogDbContext();
            // Read Product name and category name display

            var productCategory = db.Products.Include(p => p.Category).ToList();

            foreach (var item in productCategory)
            {
                Console.WriteLine($"{item.Name}\t {item.Category.Name}");
            }
        }

        private static void AddProductWithCategory()
        {
            ProductsCatalogDbContext db = new ProductsCatalogDbContext();
            // Case 1: Add a new category with new product

            var c = new Category { Name = "Smart Watch", Description = "Smart watch" };

            var p = new Product { Name = "IWatch X", Cost = 56000, Brand = "Apple", IsInStock = true, Category = c };

            db.Products.Add(p);
            //db.Categories.Add(c);
            db.SaveChanges();
            Console.WriteLine("Product and Category added.");
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
