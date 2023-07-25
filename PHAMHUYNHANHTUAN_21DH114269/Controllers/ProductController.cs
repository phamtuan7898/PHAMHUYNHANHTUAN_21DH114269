using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PHAMHUYNHANHTUAN_21DH114269.Models;
namespace PHAMHUYNHANHTUAN_21DH114269.Controllers
{
    public class ProductController : Controller
    {
        DBHelper dBHelper;
        public ProductController(ProductDBContext context)
        {
            dBHelper = new DBHelper(context);
        }
        public IActionResult Index()
        {
            ViewData["listProduct"] = dBHelper.GetProducts();
            return View();
        }

        public IActionResult Detail(int ID)
        {
            ViewBag.ProductDetail = dBHelper.GetProductByID(ID);
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductVM productVM)
        {
            // ModelState

            //Product product = new Product()
            //{
            //    ProductName = productVM.ProductName,
            //    CategoryID = 1
            //};
            //dBHelper.InsertProduct(product);
            //return RedirectToAction("index");

            if (ModelState.IsValid)
            {
                Product product = new Product()
                {
                    ProductName = productVM.ProductName,
                    CategoryID = 1
                };
                dBHelper.InsertProduct(product);
                return RedirectToAction("index");
            }


            return View(productVM);
        }

        public IActionResult Edit(int id)
        {
            ProductVM pVM = new ProductVM()
            {
                ProductId = id,
                ProductName = dBHelper.GetProductByID(id).ProductName
            };
            if (pVM == null) return NotFound();
            else return View(pVM);
        }
        [HttpPost]
        public IActionResult Edit(ProductVM productVM)
        {
            if (ModelState.IsValid)
            {
                Product newProduct = new Product()
                {
                    ID = productVM.ProductId,
                    ProductName = productVM.ProductName,
                    CategoryID = 1
                };
                dBHelper.EditProduct(newProduct);
                return RedirectToAction("Index");
            }
            return View(productVM);
        }

        public IActionResult Delete(int id)
        {
            ProductVM pVM = new ProductVM()
            {
                ProductId = id,
                ProductName = dBHelper.GetProductByID(id).ProductName
            };
            if (pVM == null) return NotFound();
            else return View(pVM);
        }
        [HttpPost]
        public IActionResult Delete(ProductVM productVM)
        {
            if (ModelState.IsValid)
            {
                dBHelper.DeleteProduct(productVM.ProductId);
                return RedirectToAction("Index");
            }
            return View(productVM);
        }
    }
}
