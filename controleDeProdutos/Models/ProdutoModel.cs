using System.Diagnostics.CodeAnalysis;

namespace controleDeProdutos.Models
{
    public class ProdutoModel
    {
        public Int64 Id { get; set; }
        public string CodigoDeBarras { get; set; }
        public string Descricao { get;}
        public DateTime DataDeValidade { get; set; }
        public DateTime DataDeRegistro { get; set; }
        public Int64 Quantidade { get; set; }
        public double Valor { get; set; }
        [MaybeNull]
        public string NomeDaFoto { get; set; }
        [MaybeNull]
        public byte[] Foto { get; set; }
        public bool Ativo { get; set; }


    }
}
