using Modelo.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services.Interface
{
    public interface IPlacaService
    {
        Task<PlacaDto> AddPlaca(PlacaDto model);
        Task<List<PlacaDto>> GetAllPlaca();
        Task<PlacaDto> GetPlacaById(int Id);
        Task<PlacaDto> UpdatePlaca(int Id, PlacaDto model);
        Task<bool> DeletePlaca(int Id);
    }
}
