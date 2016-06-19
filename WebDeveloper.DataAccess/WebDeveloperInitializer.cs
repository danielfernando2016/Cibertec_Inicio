using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class WebDeveloperInitializer : DropCreateDatabaseAlways<WebContextDb>
    {
        //Siempre que se ejecuta la Aplicacion Borramos y Creamos la BD
        //Si actualizo el modelo con nueva Propiedad podemos usar la segunda Opcion
        protected override void Seed(WebContextDb context)
        {
            var clients = new List<Client>
            {
                new Client { ID=1,Name ="Juan",LastName="Perez" },
                new Client { ID=2,Name ="Jose",LastName="Perez" },
                new Client { ID=3,Name ="Juanelo",LastName="Perez" },
                new Client { ID=4,Name ="Alan",LastName="Perez" },
                new Client { ID=5,Name ="Pedro",LastName="Perez" }
            };

            clients.ForEach(c => context.Clients.Add(c));

            var products = new List<Product>
            {
                new Product { ID =1,ProductName  ="Cuaderno",CreateDate=DateTime.Now,ProductStock=1000,PurchasePrice= 41.15 },
                new Product { ID =2,ProductName  ="Lapicero",CreateDate=DateTime.Now,ProductStock=2000,PurchasePrice= 33.40  },
                new Product { ID =3,ProductName  ="Lapiz",CreateDate=DateTime.Now,ProductStock=3000,PurchasePrice= 61.00 },
                new Product { ID =4,ProductName  ="Borrador",CreateDate=DateTime.Now,ProductStock=4000,PurchasePrice= 17.50 },
                new Product { ID =5,ProductName  ="Compas",CreateDate=DateTime.Now,ProductStock=5000 ,PurchasePrice= 81.50 }
            };

            products.ForEach(p => context.Products.Add(p));


            context.SaveChanges();
        }
    }
}
