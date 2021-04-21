using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP1_ORM_Suarez_Carlos.Models
{
    public class ComandaMercaderia
    {

        [Key][Required]
        public int ComandaMercaderiaId { get; set; }
        [Required]
        public int MercaderiaId { get; set; }
        [ForeignKey("MercaderiaId")]
        public Mercaderia Mercaderia { get; set; }
        [Required]
        public Guid ComandaId { get; set; }
        [ForeignKey("ComandaId")]
        public Comanda Comanda { get; set; }
    }
}
