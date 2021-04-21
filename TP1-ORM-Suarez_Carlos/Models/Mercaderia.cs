using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP1_ORM_Suarez_Carlos.Models
{
    public class Mercaderia
    {
        [Key][Required]
        public int MercaderiaId { get; set; }
        [Required]
        public string Nombre { get; set;}
        [Required]
        public int TipoMercaderiaId { get; set; }
        [Required][ForeignKey("TipoMercaderiaId")]
        public TipoMercaderia TipoMercaderia { get; set; }
        [Required]
        public int Precio { get; set; }
        [Required]
        public string Ingredientes { get; set; }
        [Required]
        public string Preparacion { get; set;}
        [Required]
        public string Imagen { get; set; }
        public List<ComandaMercaderia> ComandaMercaderia { get; set; }
    }
}
