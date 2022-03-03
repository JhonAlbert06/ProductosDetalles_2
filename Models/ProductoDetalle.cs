using System.ComponentModel.DataAnnotations;

namespace Productos_Detalle.Models
{
    public class ProductoDetalle
    {
        [Key]
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string Presentacion { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }

        public ProductoDetalle()
        {
            this.Id = 0;
            this.ProductoId = 0;
            this.Presentacion = "";
            this.Cantidad = 0;
            this.Precio = 0;
        }

        public ProductoDetalle(string presentacion, int cantidad, double precio)
        {
            this.Presentacion = presentacion;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }

    }
}