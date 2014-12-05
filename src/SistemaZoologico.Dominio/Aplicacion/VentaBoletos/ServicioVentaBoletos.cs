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

        public int CrearVenta(CrearVenta datosVenta)
        {
            using (ISession session = FabricaSession.Crear())
            {
                using (ITransaction transaccion = session.BeginTransaction())
                {
                    var cliente = new Cliente(
                        datosVenta.NombreCliente, datosVenta.ApellidoCliente, datosVenta.TelefonoCliente);
                    var venta = new Venta(cliente);

                    foreach (DatosDetalleVenta datosDetalleVenta in datosVenta.DetalleVentas)
                    {
                        venta.AgregarDetalle(
                            session.Get<TipoBoleto>(datosDetalleVenta.IdTipoBoleto), datosDetalleVenta.Cantidad);
                    }

                    venta.CalcularTotal();
                    session.SaveOrUpdate(venta);

                    transaccion.Commit();
                    return venta.Id;
                }
            }
        }

        public void CrearTipoBoleto(CrearTipoBoleto crearTipoBoleto)
        {
            using (ISession session = FabricaSession.Crear())
            {
                using (ITransaction transaccion = session.BeginTransaction())
                {
                    var tipoBoleto = new TipoBoleto(crearTipoBoleto.Descripcion, crearTipoBoleto.Precio);

                    session.SaveOrUpdate(tipoBoleto);

                    transaccion.Commit();
                }
            }
        }

        public void ModificarTipoBoleto(ModificarTipoBoletos modificarTipoBoletos)
        {
            using (ISession session = FabricaSession.Crear())
            {
                using (ITransaction transaccion = session.BeginTransaction())
                {
                    var tipoBoleto = session.Get<TipoBoleto>(modificarTipoBoletos.Id);

                    tipoBoleto.Descripcion = modificarTipoBoletos.Descripcion;
                    tipoBoleto.Precio = modificarTipoBoletos.Precio;

                    session.SaveOrUpdate(tipoBoleto);

                    transaccion.Commit();
                }
            }
        }

        public Venta ObtenerVenta(int idVenta)
        {
            using (ISession session = FabricaSession.Crear())
            {
                return
                    session.Query<Venta>()
                           .Where(venta => venta.Id == idVenta)
                           .Fetch(venta => venta.Cliente)
                           .FetchMany(venta => venta.Detalle)
                           .ThenFetch(venta => venta.TipoBoleto)
                           .Single();
            }
        }
    }
}