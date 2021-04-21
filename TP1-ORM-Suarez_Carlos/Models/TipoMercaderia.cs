using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP1_ORM_Suarez_Carlos.Models
{
    public class TipoMercaderia
    {
        [Key][Required]
        public int TipoMercaderiaId { get; set; }
        [Required]
        public string Descripcion { get; set; }
    }
}
