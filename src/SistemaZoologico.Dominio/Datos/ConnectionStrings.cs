using System.Configuration;

namespace SistemaZoologico.Dominio.Datos
{
    public class ConnectionStrings
    {
        public static ConnectionStringSettings Get()
        {
            return ConfigurationManager.ConnectionStrings["db"];
        }
    }
}