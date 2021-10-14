using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace RelatorioLivro
{
    public class Relatorio : IRelatorio
    {
        //Conectando com a interface de Catalogo
        private readonly ICatalogo catalogo;

        public Relatorio(ICatalogo catalogo)
        {
            this.catalogo = catalogo;
        }

        public async Task Imprimir(HttpContext context)
        {
            foreach (var livro in catalogo.GetLivro())//Inicializando o método GetLivros (que foi criado na classe catálogo)
            {
                //-10 = jogar mais à esquerda, -50 centralizar, 10 deixar mais à direita
                //C = formatador de moeda
                await context.Response.WriteAsync($"{livro.Codigo,-10}" +
                    $"{livro.Nome,-50}{livro.Preco.ToString("C"),10}\n");
            }
        }

    }
}
