using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstEntityProject.Controllers
{
    public class ProductController : Controller
    {
        private ProductService _prodService;

        public ProductController()
        {
            _prodService = new ProductService();
        }
        // GET: Customer

        public ActionResult AllProducts()
        {
            IEnumerable<Products> allProducts = _prodService.GetAllProducts();
            return View(allProducts);
        }

        public ActionResult Details(int id)
        {
            Products product = _prodService.GetProduct(id);
            return View(product);
        }

        [HttpGet]
        public ActionResult Insert()
        {
            return View(new Products());
        }

        [HttpPost]
        public ActionResult Inserted(Products product)
        {
            product.ProductID =
                (product.ProductName +
                product.UnitPrice)
                .GetHashCode();

            _prodService.InsertProduct(product);
            return RedirectToAction("AllProducts");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Products product = _prodService.GetProduct(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edited(Products product)
        {
            _prodService.EditProduct(product);
            return RedirectToAction("AllProducts");
        }

        public ActionResult Delete(int id)
        {
            _prodService.DeleteProduct(id);
            return RedirectToAction("AllProducts");
        }
    }
}