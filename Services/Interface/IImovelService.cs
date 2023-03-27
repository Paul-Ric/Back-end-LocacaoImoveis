using Locacao_imoveis.Models;

namespace Locacao_imoveis.Services.Interface
{
    public interface IImovelService
    {
        Task<List<Imovel>> GetImoveisAsync();
        Task<Imovel> GetImovelByIdAsync(int id);
        Task<Imovel> AddImovelAsync(Imovel imovel);
        Task UpdateImovelAsync(Imovel imovel);
        Task DeleteImovelAsync(int id);
    }
}
