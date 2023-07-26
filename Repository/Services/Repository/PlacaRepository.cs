using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Modelo;
using Modelo.Dto;
using Repository.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services.Repository
{
    public class PlacaRepository : IPlacaService
    {
        private readonly XtrackingContext _xtrackingContext;
        private readonly IMapper _mapper;

        public PlacaRepository(XtrackingContext xtrackingContext, IMapper mapper)
        {
            _xtrackingContext = xtrackingContext;
            _mapper = mapper;
        }

        public async Task<PlacaDto> AddPlaca(PlacaDto model)
        {
            try
            {
                var placa = _mapper.Map<Placa>(model);
                _xtrackingContext.Placas.Add(placa);

                if (await _xtrackingContext.SaveChangesAsync() > 0)
                {
                    var retorno = await GetPlacaById(placa.PlacaId);
                    return retorno;
                }

                return null;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<List<PlacaDto>> GetAllPlaca()
        {
            try
            {
                var placas = await _xtrackingContext.Placas.ToListAsync();
                var listaMapper = _mapper.Map<List<PlacaDto>>(placas);

                return listaMapper;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<PlacaDto> GetPlacaById(int id)
        {
            try
            {
                var placa = await _xtrackingContext.Placas.FirstOrDefaultAsync(p => p.PlacaId == id);

                if (placa == null)
                {
                    return null;
                }

                var placaMapper = _mapper.Map<PlacaDto>(placa);
                return placaMapper;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<PlacaDto> UpdatePlaca(int id, PlacaDto model)
        {
            try
            {
                var recuperaPlaca = await _xtrackingContext.Placas.FirstOrDefaultAsync(p => p.PlacaId == id);
                var placaMapper = _mapper.Map(model, recuperaPlaca);
                placaMapper.PlacaId = id;

                _xtrackingContext.Placas.Update(placaMapper);

                if(await _xtrackingContext.SaveChangesAsync() > 0)
                {
                    var retorno = await GetPlacaById(placaMapper.PlacaId);
                    return retorno;
                }

                return null;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeletePlaca(int id)
        {
            try
            {
                var recuperaPlaca = await _xtrackingContext.Placas.FirstOrDefaultAsync(p => p.PlacaId == id);

                if(recuperaPlaca == null)
                {
                    throw new Exception("Servico para delete nao encontrado.");
                }

                _xtrackingContext.Placas.Remove(recuperaPlaca);
                if(await _xtrackingContext.SaveChangesAsync() > 0)
                    return true;

                return false;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
