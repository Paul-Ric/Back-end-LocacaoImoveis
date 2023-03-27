using Locacao_imoveis.Models;
using Locacao_imoveis.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Locacao_imoveis.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImovelController : ControllerBase
    {
        private readonly IImovelService _imovelService;

        public ImovelController(IImovelService imovelService)
        {
            _imovelService = imovelService;
        }
        [HttpGet]
        [Route("/imoveis")]
        public async Task<IActionResult> GetImoveis()
        {
            try
            {
                var imoveis = await _imovelService.GetImoveisAsync();
                return Ok(imoveis);
            } catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetImovelById(int id)
        {
            try
            {
                var imovel = await _imovelService.GetImovelByIdAsync(id);
                if (imovel == null)
                {
                    return NotFound();
                }

                return Ok(imovel);
            } catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateImovel(Imovel imovelDto)
        {
            try
            {
                var imovel = await _imovelService.AddImovelAsync(imovelDto);
                return CreatedAtAction(nameof(GetImovelById), new { id = imovel.Id }, imovel);
            } catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateImovel(int id, [FromBody] Imovel imovel)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var existingImovel = await _imovelService.GetImovelByIdAsync(id);

            if (existingImovel == null)
                return NotFound();

            await _imovelService.UpdateImovelAsync(imovel);

            return Ok(imovel);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImovel(int id)
        {
            var existingImovel = await _imovelService.GetImovelByIdAsync(id);

            if (existingImovel == null)
                return NotFound();

            await _imovelService.DeleteImovelAsync(id);

            return NoContent();
        }
    }
}

