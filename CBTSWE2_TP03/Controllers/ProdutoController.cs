using CBTSWE2_TP03.Models;
using CBTSWE2_TP03.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CBTSWE2_TP03.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository; 

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Produto produto)
        {
            if (ModelState.IsValid)
            { 
                _produtoRepository.AddProduto(produto);
                return RedirectToAction("Index", "Home");   
            }
            else
            {
                return View(produto);
            }
        }
    }
}
