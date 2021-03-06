﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicada2ProyectoFinal.Models
{
    public class TiposUsuarios
    {
        [Key]
        public int TipoUsuarioId { get; set; }
        [Required(ErrorMessage = "Descripcion no puede estar vacia")]
        public string Descripcion { get; set; }
        public TiposUsuarios()
        {
            TipoUsuarioId = 0;
            Descripcion = string.Empty;
        }
    }
}
