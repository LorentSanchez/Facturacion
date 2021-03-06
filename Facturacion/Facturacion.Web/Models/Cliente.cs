﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Facturacion.Web.Datos.Entidades
{
    public class Cliente
    {
        [Required]//para que los campos sea obliatorios llenarlos 
        [MaxLength(15)]//en tama$o maximo que tendran los campos 
        [Display(Name ="Identidad")]
        public int DocumentoId { get; set; }
        [Required]
        [MaxLength(20)]
        [Display(Name = "Nombre del cliente ")]
        public string NombreC { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name ="Apellido del Cliente")]
        public string ApellidoC { get; set; }
        [Required]
        [MaxLength(15)]
        [Display(Name ="Telefono")]
        public int  TelefonC { get; set; }
        [Required]
        [MaxLength(200)]
        [Display(Name ="Direccion")]
        public string DireccionC { get; set; }

        public string NombreCompleto => $"{NombreC} {ApellidoC}";

        //public int MyProperty { get; set; }
        //public int MyProperty { get; set; }
    }
}
