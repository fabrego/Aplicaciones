using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace Sistema_de_Inventario
{
    //Verificando este cambio afuera en el namespace
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                Console.WriteLine("Hello World");
                Console.WriteLine("Otro Cambio");
                Console.WriteLine("De nuevo");
                Console.WriteLine("No jodas jajaj");
                //prueba de cambio
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
