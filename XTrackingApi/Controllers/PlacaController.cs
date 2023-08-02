using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo.Dto;
using Repository.Services.Interface;

namespace XTrackingApi.Controllers
{
    [Route("xtracking/api/[controller]")]
    [ApiController]
    public class PlacaController : ControllerBase
    {
        private readonly IPlacaService _placaService;

        public PlacaController(IPlacaService placaService)
        {
            _placaService = placaService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PlacaDto dto)
        {
            try
            {
                var request = await _placaService.AddPlaca(dto);

                if(request == null)
                {
                    return NoContent();
                }

                return Ok(request);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar adicionar Placa. Erro: {ex.Message}");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var request = await _placaService.GetAllPlaca();

                if (request == null)
                {
                    return NoContent();
                }

                return Ok(request);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar adicionar Placa. Erro: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var request = await _placaService.GetPlacaById(id);

                if (request == null)
                {
                    return NotFound("Placa nao encontrada");
                }

                return Ok(request);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar adicionar Placa. Erro: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] PlacaDto placaDto)
        {
            try
            {
                var request = await _placaService.UpdatePlaca(id, placaDto);

                if (request == null)
                {
                    return NotFound("Placa nao encontrada");
                }

                return Ok(request);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar adicionar Placa. Erro: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var request = await _placaService.DeletePlaca(id);

                if (request == null)
                {
                    return NotFound("Placa nao encontrada");
                }

                return Ok(request);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar adicionar Placa. Erro: {ex.Message}");
            }
        }
    }
}
