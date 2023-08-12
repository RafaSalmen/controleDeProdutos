using controleDeProdutos.Models;
using controleDeProdutos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace controleDeProdutos.Controllers
{
    public class ProdutoController : Controller
    { 

        private readonly IProdutoRepositorio _produtoRepositorio;

    public ProdutoController(IProdutoRepositorio produtoRepositorio)
    { 
        _produtoRepositorio = produtoRepositorio;
    } 
    
        public IActionResult Index() {


            List<ProdutoModel> produtos = _produtoRepositorio.BuscarTodos();
            return View(produtos); }

        
    

        public IActionResult Criar() { return View(); }
        public IActionResult Editar() { return View(); }
        public IActionResult ApagarConfirmacao() { return View(); }

        [HttpPost]
        public IActionResult criar(ProdutoModel produto)
        {
            ProdutoModel model = produto;
            model.DataDeRegistro = DateTime.Now;
            _produtoRepositorio.Adicionar(model);

            return RedirectToAction("Index");
        }
    }
}
