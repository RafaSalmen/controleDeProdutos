using controleDeProdutos.Models;

namespace controleDeProdutos.Repositorio
{
    public interface IProdutoRepositorio
    {
        List<ProdutoModel> BuscarTodos();
        ProdutoModel Adicionar(ProdutoModel produto);
    }
}
