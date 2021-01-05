using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IngresosGastos.Models
{
    public class IngresosGastosFASS
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength (60, MinimumLength = 3)]
        public string Descripcion { get; set; }
        [Required]
        public bool EsIngresos { get; set; }
        [Required]
        public double valor { get; set; }
    }
}