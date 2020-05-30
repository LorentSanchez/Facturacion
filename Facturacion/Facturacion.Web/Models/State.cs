using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Facturacion.Web.Datos.Entidades
{
    public class State
    {
        [Required]
        public int StateId { get; set; }
        [Required]
        [MaxLength(30)]
        public string StateName { get; set; }

        public int CityId { get; set; }
        public City CityName { get; set; }

    }
}
