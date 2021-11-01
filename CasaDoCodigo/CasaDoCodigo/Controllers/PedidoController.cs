using System;
using Microsoft.AspNetCore.Mvc;

namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {
        //Para que vonsiga visualuzar as novas páginas que estão na pasta pedido em views
        //Para visualizá-las, colocarei pedido/nome da pg cshtml
        public IActionResult Carrossel()
        {
            return View();
        }

        public IActionResult Carrinho()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Resumo()
        {
            return View();
        }
    }
}
