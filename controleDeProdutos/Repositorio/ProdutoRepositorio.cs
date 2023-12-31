﻿using controleDeProdutos.Data;
using controleDeProdutos.Models;

namespace controleDeProdutos.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ProdutoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public ProdutoModel Adicionar(ProdutoModel produto)
        {
            _bancoContext.Produtos.Add(produto);
            _bancoContext.SaveChanges();

            return produto;
        }

        public List<ProdutoModel> BuscarTodos()
        {
            return _bancoContext.Produtos.ToList();
        }
    }
}
