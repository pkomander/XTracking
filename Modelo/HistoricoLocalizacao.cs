using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class HistoricoLocalizacao
    {
        [Key]
        [Required]
        public int HistoricoLocalizacaoId { get; set; }
        public int PlacaId { get; set; }
        public virtual Placa Placa { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime? Data { get; set; }
        //public int UserId { get; set; }
    }
}
