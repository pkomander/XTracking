using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Placa
    {
        [Key]
        [Required]
        public int PlacaId { get; set; }
        public string PlacaNumeroSerie { get; set; }
        public string NomePlaca { get; set; }
        //public int UserId { get; set; }
    }
}
