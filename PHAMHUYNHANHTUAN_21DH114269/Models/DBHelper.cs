using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHAMHUYNHANHTUAN_21DH114269.Models
{
    public class DBHelper : Controller
    {
        ProductDBContext _db;
        public DBHelper(ProductDBContext db)
        {
            _db = db;
        }
        public List<Product> GetProducts()
        {
            return _db.Products.ToList();
        }

        public Product GetProductByID(int id)
        {
            return _db.Products.First(x => x.ID == id);
        }

        public void InsertProduct(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
        }

        public void EditProduct(Product newProduct)
        {
            _db.Products.Update(newProduct);
            _db.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            Product product = GetProductByID(id);
            _db.Products.Remove(product);
            _db.SaveChanges();
        }
    }
}
