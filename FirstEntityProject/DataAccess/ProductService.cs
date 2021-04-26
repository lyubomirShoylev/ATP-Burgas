using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductService
    {
        private NORTHWNDEntities _Db;

        public ProductService()
        {
            _Db = new NORTHWNDEntities();
        }
        
        public IEnumerable<Products> GetAllProducts()
         {
             return _Db.Products;
         }

        public Products GetProduct(int id)
        {
            Products prod =
                (from product in _Db.Products
                 where product.ProductID == id
                 select product).SingleOrDefault();

            return prod;
        }

        public void InsertProduct(Products product)
        {
            _Db.Products.Add(product);
            _Db.SaveChanges();
        }

        public void EditProduct(Products product)
        {
            Products prod =
                (from products in _Db.Products
                 where products.ProductID == product.ProductID
                 select products).SingleOrDefault();

            prod.ProductName = product.ProductName;
            prod.UnitPrice = product.UnitPrice;
            _Db.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            Products prod = this.GetProduct(id);
            _Db.Products.Remove(prod);
            _Db.SaveChanges();
        }
    }
}
