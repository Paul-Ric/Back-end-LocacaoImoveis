using Locacao_imoveis.Models;
using Locacao_imoveis.Repository;
using Locacao_imoveis.Services.Interface;

namespace Locacao_imoveis.Services
{
    public class ImovelService : IImovelService
    {
        private readonly IImovelRepository _imovelRepository;

        public ImovelService(IImovelRepository imovelRepository)
        {
            _imovelRepository = imovelRepository;
        }

        /*public async Task<List<Imovel>> GetAllImoveisAsync()
        {
            return await _imovelRepository.GetImoveisAsync();
        }*/
        public async Task<List<Imovel>> GetImoveisAsync()
        {
            return await _imovelRepository.GetImoveisAsync();
        }
        public async Task<Imovel> GetImovelByIdAsync(int id)
        {
            return await _imovelRepository.GetImovelByIdAsync(id);
        }

        public async Task AddImovelAsync(Imovel imovel)
        {
             await _imovelRepository.AddImovelAsync(imovel);
        }

        public async Task UpdateImovelAsync(Imovel imovel)
        {
            await _imovelRepository.UpdateImovelAsync(imovel);
        }

        Task IImovelService.DeleteImovelAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<Imovel> IImovelService.AddImovelAsync(Imovel imovel)
        {
            throw new NotImplementedException();
        }
    }
}
