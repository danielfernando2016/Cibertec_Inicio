using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class RazorController : Controller
    {
        // GET: Razor
        public ActionResult Index()
        {
           
            List<Client> list = new List<Client>()         
            {
                new Client { ID = 1, Name = "Jose", LastName = "Perez" },
                new Client { ID = 2, Name = "Juan", LastName = "Lopez" }
            }; 

            return View(list);
        }
    }
}