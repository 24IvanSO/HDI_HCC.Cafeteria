using System.ComponentModel.DataAnnotations;

namespace HDI_HCC.Cafeteria.Models
{
    public class Tb_HccOrdenes
    {
        
        [Key]
        public int ord_id { get; set; }
        public int mes_id { get; set; }
        public int catord_id { get; set; }
        public  DateTime ord_fecha_inicio { get; set; }
        public int ord_estatus { get; set; }


    }
}
