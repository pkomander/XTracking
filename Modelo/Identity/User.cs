﻿using Microsoft.AspNetCore.Identity;
using Modelo.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Identity
{
    public class User : IdentityUser<int>
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string? Descricao { get; set; }
        public Funcao Funcao { get; set; }
        public string? ImagemURL { get; set; }
        public IEnumerable<UserRole> UserRoles { get; set; }
    }
}
