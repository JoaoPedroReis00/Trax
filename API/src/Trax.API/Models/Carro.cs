namespace Trax.API.Models
{
    public class Carro
    {
        public Carro () {}

        public Carro (int id, string nome, string marca, int ano, string img)
        {
            Id = id;
            Nome = nome;
            Marca = marca;
            Ano = ano;
            Img = img;
        }
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public string Img { get; set; }
    }
}
