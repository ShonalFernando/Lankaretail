using LankaRetail.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcePlanner.Service.Modules
{
    internal class InventoryService
    {
        public List<Product> GetAllProducts()
        {
            using var db = DbContextFactory.Create();
            return db.Products.Include(p => p.Category).ToList();
        }

        public void AddProduct(Product product)
        {
            using var db = DbContextFactory.Create();
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            using var db = DbContextFactory.Create();
            db.Products.Update(product);
            db.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            using var db = DbContextFactory.Create();
            var product = db.Products.Find(id);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
            }
        }
    }
}
