using Catalogo.Domain.ValueObjects;
using System;

namespace Catalogo.Domain.Entities
{
    public class Produto : EntityBase
    {
        protected Produto()
        {
        }

        public Produto(string nome,
            string descricao,
            Dinheiro preco,
            Imagem imagem,
            int estoque,
            DateTime dataCadastro,
            Guid categoriaId)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Imagem = imagem;
            Estoque = estoque;
            DataCadastro = dataCadastro;
            CategoriaId = categoriaId;
        }

        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public Dinheiro Preco { get; private set; }
        public Imagem Imagem { get; private set; }
        public int Estoque { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public Categoria Categoria { get; private set; }
        public Guid CategoriaId { get; private set; }

        public void SetUpdate(string nome,
            string descricao,
            Dinheiro preco,
            Imagem imagem,
            Guid categoriaId)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Imagem = imagem;
            CategoriaId = categoriaId;
        }
    }
}
