using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private ProductData _product = new ProductData();
        // GET: Product
        public ActionResult Index()
        {
            return View(_product.GetList());

        }

        public ActionResult Create()
        {
            return View(new Product());
        }

        [HttpPost]
        public ActionResult Create(Product Product)
        {
            //Primero
            if (ModelState.IsValid)
            {
                _product.Add(Product);
                return RedirectToAction("Index");
            }
            return View();
        }

        //Edit
        public ActionResult Edit(int id)
        {


            var Product = _product.GetProductById(id);
            if (Product == null)
                RedirectToAction("Index");
            return View(Product);

        }

        //Edit Post
        [HttpPost]
        public ActionResult Edit(Product Product)
        {
            //Primero
            if (ModelState.IsValid)
            {
                _product.Update(Product);
                return RedirectToAction("Index");
            }
            return View();
        }


        //Delete
        public ActionResult Delete(int id)
        {


            var Product = _product.GetProductById(id);
            if (Product == null)
                RedirectToAction("Index");
            return View(Product);

        }

        //Delete Post
        [HttpPost]
        public ActionResult Delete(Product Product)
        {
            if (_product.Delete(Product) > 0)
                return RedirectToAction("Index");

            return View();
        }
    }
}