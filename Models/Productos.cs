using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductosDetalles_2.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public double Costo { get; set; }
        public double ValorInventario { get; set; }



        [ForeignKey("ProductoId")]
        public List<ProductosDetalle> Detalle { get; set; } = new List<ProductosDetalle> ();
    }
}