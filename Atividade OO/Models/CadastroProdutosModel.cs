using System;

namespace Atividade_OO.Models
{
    public class CadastroProdutosModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Categoria { get; set; }

        public float Preco { get; set; }

        public int QuantidadeEstoque { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}