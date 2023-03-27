namespace Locacao_imoveis.Models
{
    public class Locacao
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public decimal ValorMensal { get; set; }

        public int ImovelId { get; set; }
        public Imovel Imovel { get; set; }

        public int UsuarioId { get; set; }
        public User Usuario { get; set; }
    }
}
