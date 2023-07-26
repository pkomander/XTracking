using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class XtrackingContext : DbContext
    {
        public XtrackingContext(DbContextOptions<XtrackingContext> opt) : base(opt) { }
        
        public DbSet<Placa> Placas { get; set; }
        public DbSet<HistoricoLocalizacao> HistoricoLocalizacaos { get; set; }
    }
}
