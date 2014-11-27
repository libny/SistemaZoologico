using System.Collections.Generic;
using System.Linq;
using NHibernate;
using NHibernate.Linq;
using SistemaZoologico.Dominio.Aplicacion.VentaBoletos.Commandos;
using SistemaZoologico.Dominio.Datos;
using SistemaZoologico.Dominio.Entidades;

namespace SistemaZoologico.Dominio.Aplicacion.VentaBoletos
{
    public class ServicioVentaBoletos
    {
        public IEnumerable<TipoBoleto> ObtenerTipoBoletos()
        {
            using (ISession session = FabricaSession.Crear())
            {
                List<TipoBoleto> obtenerTipoBoletos = session.Query<TipoBoleto>().ToList();

                return obtenerTipoBoletos;
            }
        }

        public void CrearVenta(CrearVenta datosVenta)
        {
            using (ISession session = FabricaSession.Crear())
            {
                using (ITransaction transaccion = session.BeginTransaction())
                {
                    var cliente = new Cliente(datosVenta.NombreCliente, datosVenta.ApellidoCliente,
                        datosVenta.TelefonoCliente);
                    var venta =new Venta(cliente);

                    foreach (var datosDetalleVenta in datosVenta.DetalleVentas)
                    {
                        venta.AgregarDetalle(session.Get<TipoBoleto>(datosDetalleVenta.IdTipoBoleto), datosDetalleVenta.Cantidad);
                    }
                }
            }
        }
    }
}