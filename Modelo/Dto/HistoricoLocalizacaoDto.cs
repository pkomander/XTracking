using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Dto
{
    public class HistoricoLocalizacaoDto
    {
        public int? HistoricoLocalizacaoId { get; set; }
        [Required(ErrorMessage = "O Id da placa e obrigatorio")]
        public int PlacaId { get; set; }
        [Required(ErrorMessage = "A {0} e obrigatorio")]
        [MinLength(3, ErrorMessage = "{0} deve ter no minimo 4 caracteres.")]
        [MaxLength(100, ErrorMessage = "{0} deve ter no maximo 100 caracteres.")]
        public string Latitude { get; set; }
        [Required(ErrorMessage = "A {0} e obrigatorio")]
        [MinLength(3, ErrorMessage = "{0} deve ter no minimo 4 caracteres.")]
        [MaxLength(100, ErrorMessage = "{0} deve ter no maximo 100 caracteres.")]
        public string Longitude { get; set; }
        public DateTime? Data { get; set; }
    }
}
