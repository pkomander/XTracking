using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo.Dto;
using Repository.Services.Interface;

namespace XTrackingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoricoLocalizacaoController : ControllerBase
    {
        private readonly IHistoricoLocalizacaoService _historicoLocalizacaoService;
        public HistoricoLocalizacaoController(IHistoricoLocalizacaoService historicoLocalizacaoService)
        {
            _historicoLocalizacaoService = historicoLocalizacaoService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] HistoricoLocalizacaoDto historicoDto)
        {
            try
            {
                var request = await _historicoLocalizacaoService.AddLocalizacao(historicoDto);

                if(request == null)
                {
                    return NoContent();
                }

                return Ok(request);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar adicionar Historico. Erro: {ex.Message}");
            }
        }

        [HttpGet("{placaId}")]
        public async Task<IActionResult> GetAllLocalization(int placaId)
        {
            try
            {
                var request = await _historicoLocalizacaoService.GetLocalizacao(placaId);

                if(request == null)
                {
                    return NoContent();
                }

                return Ok(request);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar Historico. Erro: {ex.Message}");
            }
        }
    }
}
