using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Facturacion.Web.Datos.Entidades
{
    public class Neighborhood
    {
        [Required]
        public int NeighborhoodId { get; set; }
        [Required]
        [MaxLength(30)]
        public string NeighborhoodName { get; set; }

        public int CityId { get; set; }
        public string CityName { get; set; }
    }
}
