using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using Web_API.Models;


namespace Web_API.Servicios
{
    public class Servicio_API 
        
    {
        //Creacion de variables
        private static String _usuario;
        private static String _clave;
        private static String _baseurl;
        private static String _Token;
        //constructor
        public Servicio_API()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings,Json").Build();

            _usuario = builder.GetSection("ApiSettings:usuario").Value;
            _clave = builder.GetSection("ApiSettings:clave").Value;
            _baseurl = builder.GetSection("ApiSettings:baseUrl").Value;

        }
    }
}
