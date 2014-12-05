using System.Collections.Generic;
using System.Linq;
using NHibernate;
using NHibernate.Linq;
using SistemaZoologico.Dominio.Aplicacion.Animales.Comandos;
using SistemaZoologico.Dominio.Datos;
using SistemaZoologico.Dominio.Entidades;

namespace SistemaZoologico.Dominio.Aplicacion.Animales
{
    public class ServiciosAnimales
    {
        public void CrearAnimal(Crearanimales datosanimales)

        {
            using (ISession session = FabricaSession.Crear())
            {
                using (ITransaction trasancion = session.BeginTransaction())
                {
                    var especie = session.Get<Especie>(datosanimales.IdEspecie);
                    var animal = new Animal(datosanimales.Nombre, datosanimales.Edad, especie,
                        datosanimales.FechaIngreso,
                        datosanimales.FechaNacimiento, datosanimales.OrigenAnimal);
                    session.SaveOrUpdate(animal);
                    trasancion.Commit();
                }
            }
        }


        public IEnumerable<Especie> ObtenerEspecies()
        {
            using (ISession session = FabricaSession.Crear())
            {
                return session.Query<Especie>().ToList();
            }
        }

        public void Crearespecie(Crearespecie datosespecie)
        {
            using (ISession session = FabricaSession.Crear())
            {
                using (ITransaction trasancion = session.BeginTransaction())
                {
                    var especie = new Especie(datosespecie.Nombre, datosespecie.Nombrecientifico,
                        datosespecie.Descripcion);
                    session.SaveOrUpdate(especie);
                    trasancion.Commit();
                }
            }
        }

        public IEnumerable<Animal> ObtenerAnimales()
        {
            using (ISession session = FabricaSession.Crear())
            {
                return session.Query<Animal>().ToList();
            }
        }

        public void ModificarAnimal(ModificarAnimales modificarAnimales)
        {
            using (ISession session = FabricaSession.Crear())
            {
                using (ITransaction transaccion = session.BeginTransaction())
                {
                    var animal = session.Get<Animal>(modificarAnimales.IdAnimal);
                    var especie = session.Get<Especie>(modificarAnimales.IdEspecie);

                    animal.Nombre = modificarAnimales.Nombre;
                    animal.FechaIngreso = modificarAnimales.FechaIngreso;
                    animal.FechaNacimiento = modificarAnimales.FechaNacimiento;
                    animal.Origen = modificarAnimales.OrigenAnimal;
                    animal.Edad = modificarAnimales.Edad;
                    animal.Especie = especie;

                    session.SaveOrUpdate(animal);

                    transaccion.Commit();
                }
            }
        }

        public Animal ObtenerAnimal(int id)
        {
            using (ISession session = FabricaSession.Crear())
            {
                return
                    session.Query<Animal>()
                        .Where(animal => animal.Id == id)
                        .Fetch(animal => animal.Especie)
                        .Fetch(animal => animal.Origen)
                        .Single();
            }
        }
    }
}