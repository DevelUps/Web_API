namespace Web_API.Models
{
    public class Producto
    {
        public int IdProducto { get; set; } 
        public string CodigoBarras { get; set; }
        public string Marca { get; set; }
        public string Nombre { get; set;}
        public string Categoria { get; set;}
        public double Precio { get; set;}
    }
}
