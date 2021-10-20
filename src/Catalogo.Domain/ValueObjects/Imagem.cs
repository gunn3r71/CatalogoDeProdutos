namespace Catalogo.Domain.ValueObjects
{
    public class Imagem : ValueObject
    {
        public Imagem(string url)
        {
            Url = url;
        }

        public string Url { get; private set; }
    }
}
