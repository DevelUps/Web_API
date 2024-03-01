using Web_API.Models;
namespace Web_API.Servicios
{
    public interface IServicio_API
    {
        Task<List<Producto>> Lista();
        Task<Producto> Obtener(int IdProducto);

        Task<bool> Guardar(Producto objeto);
        Task<bool> Editar(Producto objeto);
        Task<bool> Eliminar(Producto objeto);
    }

}
