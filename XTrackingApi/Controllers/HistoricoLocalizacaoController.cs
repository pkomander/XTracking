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
        private readonly IHistoricoLocalizacao _historicoLocalizacaoService;
        public HistoricoLocalizacaoController(IHistoricoLocalizacao historicoLocalizacaoService)
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

        [HttpGet]
        public async Task<IActionResult> GetAllLocalization([FromBody] HistoricoLocalizacaoDto model)
        {
            try
            {
                var request = await _historicoLocalizacaoService.GetLocalizacao(model);

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
