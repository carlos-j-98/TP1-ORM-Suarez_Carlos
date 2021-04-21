using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP1_ORM_Suarez_Carlos.Models
{
    class ComandaMercaderia
    {
        [Required][ForeignKey("MercaderiaId")]
        public int MercaderiaId { get; set;}
        [Required][ForeignKey("ComandaId")]
        public Guid ComandaId { get; set; }
        [Key][Required]
        public int ComandaMercaderiaId { get; set; }
    }
}
