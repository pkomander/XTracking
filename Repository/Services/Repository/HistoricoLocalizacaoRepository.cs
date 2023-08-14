using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Modelo;
using Modelo.Dto;
using Repository.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services.Repository
{
    public class HistoricoLocalizacaoRepository : IHistoricoLocalizacaoService
    {
        private readonly XtrackingContext _xtrackingContext;
        private readonly IMapper _mapper;

        public HistoricoLocalizacaoRepository(XtrackingContext xtrackingContext, IMapper mapper)
        {
            _xtrackingContext = xtrackingContext;
            _mapper = mapper;
        }

        public async Task<bool> AddLocalizacao(HistoricoLocalizacaoDto model)
        {
            try
            {
                var placa = _mapper.Map<HistoricoLocalizacao>(model);
                _xtrackingContext.HistoricoLocalizacaos.Add(placa);

                if (await _xtrackingContext.SaveChangesAsync() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<HistoricoLocalizacaoDto>> GetLocalizacao(int placaId)
        {
            try
            {
                var listaHistorico = await _xtrackingContext.HistoricoLocalizacaos.Where(h => h.PlacaId == placaId).ToListAsync();
                if (listaHistorico == null)
                {
                    return null;
                }

                var listaMapper = _mapper.Map<List<HistoricoLocalizacaoDto>>(listaHistorico);

                return listaMapper;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
