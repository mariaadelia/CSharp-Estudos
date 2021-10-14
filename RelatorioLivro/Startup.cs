using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace RelatorioLivro
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            /*Transient
            services.AddTransient<ICatalogo, Catalogo>();
            services.AddTransient<IRelatorio, Relatorio>();
            */

            /*Scoped
            services.AddScoped<ICatalogo, Catalogo>();
            services.AddScoped<IRelatorio, Relatorio>();
            */

            /*Singleton*/
            var catalogo = new Catalogo();
            //services.AddSingleton<ICatalogo>(new Catalogo());
            services.AddSingleton<ICatalogo>(catalogo);
            //services.AddSingleton<IRelatorio>(new Relatorio(new Catalogo())); - aqui tem catalogo porque a classe catalogo é necessária em Relatorio
            services.AddSingleton<IRelatorio>(new Relatorio(catalogo));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Inicializando a classe catálogo e relatório
            ICatalogo catalogo = serviceProvider.GetService<ICatalogo>();
            IRelatorio relatorio = serviceProvider.GetService<IRelatorio>();
           
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    //Chamando o método da classe Relatório que irá gerar o relatorio de livros
                    await relatorio.Imprimir(context);
                });
            });
        }
    }
}
