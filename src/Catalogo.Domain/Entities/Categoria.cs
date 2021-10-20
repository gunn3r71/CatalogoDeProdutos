using Catalogo.Domain.ValueObjects;
using System.Collections.Generic;

namespace Catalogo.Domain.Entities
{
    public class Categoria : EntityBase
    {
        protected Categoria()
        {
        }

        public Categoria(string nome, Imagem imagem)
        {
            Nome = nome;
            Imagem = imagem;
        }

        public string Nome { get; private set; }
        public Imagem Imagem { get; private set; }
        public IEnumerable<Produto> Produtos { get; private set; }

        public void SetUpdate(string nome, Imagem imagem)
        {
            Nome = nome;
            Imagem = imagem;
        }
    }
}
