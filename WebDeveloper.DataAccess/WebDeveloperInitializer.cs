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
                new Product { ID =1,Description  ="Cuaderno",Price= 41.15 },
                new Product { ID =2,Description  ="Lapicero",Price= 33.40  },
                new Product { ID =3,Description  ="Lapiz",Price= 61.00 },
                new Product { ID =4,Description  ="Borrador",Price= 17.50 },
                new Product { ID =5,Description  ="Compas",Price= 81.50 }
            };

            products.ForEach(p => context.Products.Add(p));


            context.SaveChanges();
        }
    }
}
