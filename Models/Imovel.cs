namespace Locacao_imoveis.Models
{
    public class Imovel
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
        public decimal Valor { get; set; }
        public int NumeroQuartos { get; set; }
        public ICollection<Locacao> Locacoes { get; set; }


    }
}
