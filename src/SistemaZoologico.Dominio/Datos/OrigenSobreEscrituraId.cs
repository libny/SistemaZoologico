using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using SistemaZoologico.Dominio.Entidades;

namespace SistemaZoologico.Dominio.Datos
{
    public class OrigenSobreEscrituraId : IAutoMappingOverride<Origen>
    {
        public void Override(AutoMapping<Origen> mapping)
        {
            mapping.Id().GeneratedBy.Assigned();
        }
    }
}