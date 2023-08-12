using controleDeProdutos.Models;
using Microsoft.EntityFrameworkCore;

namespace controleDeProdutos.Data
{
    public class BancoContext: DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) :
         base (options) 
        {
            
        }

        public DbSet<ProdutoModel> Produtos { get; set; }   
    }
}
