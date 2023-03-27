using Locacao_imoveis.Models;

namespace Locacao_imoveis.Services.Interface
{
    public interface ILocacaoService
    {
        Task<List<Locacao>> GetLocacoesAsync();
        Task<Locacao> GetLocacaoByIdAsync(int id);
        Task AddLocacaoAsync(Locacao locacao);
        Task UpdateLocacaoAsync(Locacao locacao);
        Task DeleteLocacaoAsync(int id);
    }
}
