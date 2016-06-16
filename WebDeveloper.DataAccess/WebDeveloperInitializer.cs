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
                new Client { ID=1,Name ="Jose",LastName="Perez" },
                new Client { ID=1,Name ="Juanelo",LastName="Perez" },
                new Client { ID=1,Name ="Alan",LastName="Perez" },
                new Client { ID=1,Name ="Pedro",LastName="Perez" }
            };

            clients.ForEach(c => context.Clients.Add(c));
            context.SaveChanges();
        }
    }
}
