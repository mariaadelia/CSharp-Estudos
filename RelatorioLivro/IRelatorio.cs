using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace RelatorioLivro
{
    public interface IRelatorio
    {
        Task Imprimir(HttpContext context);
    }
}