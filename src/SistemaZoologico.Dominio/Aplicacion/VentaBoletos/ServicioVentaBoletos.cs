using System.Collections.Generic;
using System.Linq;
using NHibernate;
using NHibernate.Linq;
using SistemaZoologico.Dominio.Datos;
using SistemaZoologico.Dominio.Entidades;

namespace SistemaZoologico.Dominio.Aplicacion.VentaBoletos
{
    public class ServicioVentaBoletos
    {
        private readonly ISession _session;

        public ServicioVentaBoletos()
        {
            _session = FabricaSession.Crear();
        }

        public IEnumerable<TipoBoleto> ObtenerTipoBoletos()
        {
            return _session.Query<TipoBoleto>().ToList();
        }
    }
}