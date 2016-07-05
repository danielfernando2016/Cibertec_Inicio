using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class ClientController : Controller
    {
        //private ClientData _client = new ClientData();

        //private IDataAccess<Client> _client;
        private ClientData _client;

        public ClientController(ClientData client)
        //public ClientController(IDataAccess<Client> client)
        {
            _client = client;
        }

        // GET: Client
        public ActionResult Index()
        {
            //var client = new ClientData();
            //return View(client.GetFakeData());

            //var client = new ClientData();
            return View(_client.GetList());

        }

        public ActionResult Create()
        {
            return View(new Client());
        }

        [HttpPost]
        public ActionResult Create(Client client)
        {
            //Primero
            if (ModelState.IsValid)
            {
                _client.Add(client);
                return RedirectToAction("Index");
            }
            return View();
        }

        //Edit
        //public ActionResult Edit(int id)
        //{

            
        //    var client = _client.GetClientById(id);            
        //    if (client==null)
        //        RedirectToAction("Index");
        //    return View(client);

        //}

        ////Edit Post
        //[HttpPost]
        //public ActionResult Edit(Client client)
        //{
        //    //Primero
        //    if (ModelState.IsValid)
        //    {
        //        _client.Update(client);
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}


        ////Delete
        //public ActionResult Delete(int id)
        //{


        //    var client = _client.GetClientById(id);
        //    if (client == null)
        //        RedirectToAction("Index");
        //    return View(client);

        //}

        ////Edit Post
        //[HttpPost]
        //public ActionResult Delete(Client client)
        //{
        //    if (_client.Delete(client)>0)
        //        return RedirectToAction("Index");
            
        //    return View();
        //}



    }
}