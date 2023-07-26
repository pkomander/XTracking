using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Dto
{
    public class PlacaDto
    {
        public int? PlacaId { get; set; }
        [Required(ErrorMessage = "O Numero de Serie do da Placa e obrigatorio")]
        [MinLength(3, ErrorMessage = "{0} deve ter no minimo 4 caracteres.")]
        [MaxLength(100, ErrorMessage = "{0} deve ter no maximo 100 caracteres.")]
        public string PlacaNumeroSerie { get; set; }
        [Required(ErrorMessage = "O Nome da Placa e obrigatorio")]
        [MinLength(3, ErrorMessage = "{0} deve ter no minimo 4 caracteres.")]
        [MaxLength(100, ErrorMessage = "{0} deve ter no maximo 100 caracteres.")]
        public string NomePlaca { get; set; }
    }
}
