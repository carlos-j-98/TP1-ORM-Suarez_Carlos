using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP1_ORM_Suarez_Carlos.Models
{
    public class Comanda
    {
        [Key][Required]
        public Guid ComandaId { get; set; }
        [Required][ForeignKey("FormaEntregaId")]
        public int FormaEntregaId { get; set; }
        [Required]
        public int PrecioTotal { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
    }
}
