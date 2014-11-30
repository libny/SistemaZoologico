using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace SistemaZoologico.Dominio.Datos
{
    public class PrimarkeyConvention :   IIdConvention
    {
        public void Apply(IIdentityInstance instance)
        {
           // instance.GeneratedBy.Identity();
        }
    }
}