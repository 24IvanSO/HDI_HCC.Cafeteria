using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HDI_HCC.Cafeteria.Models
{
    public class Tb_HccProductos
    {
        
        [Key]
        public int pro_id { get; set; } 
        public int alm_id { get; set; }
        [MaxLength(50,ErrorMessage ="El campo {0} debe tener maximo {1} caracteres.")]
        public string pro_nombre { get; set; }
        [DataType(DataType.MultilineText)]
        [MaxLength(50, ErrorMessage = "El campo {120} debe tener maximo {1} caracteres.")]
        public string pro_descripcion { get; set; }
        [Column(TypeName ="decimal(10,4)")]
        [DisplayFormat(DataFormatString ="{0:C2}")]
        public decimal pro_precio { get; set; }
        public int pro_estatud { get; set; } 
    }
}
