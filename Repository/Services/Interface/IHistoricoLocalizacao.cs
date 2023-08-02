﻿using Modelo.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services.Interface
{
    public interface IHistoricoLocalizacao
    {
        Task<bool> AddLocalizacao(HistoricoLocalizacaoDto model);
        Task<List<HistoricoLocalizacaoDto>> GetLocalizacao(HistoricoLocalizacaoDto model);
    }
}
