using Locacao_imoveis.Models;

namespace Locacao_imoveis.Repository
{
    public interface IImovelRepository
    {
        Task<List<Imovel>> GetImoveisAsync();
        Task<Imovel> GetImovelByIdAsync(int id);
        Task AddImovelAsync(Imovel imovel);
        Task UpdateImovelAsync(Imovel imovel);
        Task DeleteImovelAsync(int id);
    }
}
