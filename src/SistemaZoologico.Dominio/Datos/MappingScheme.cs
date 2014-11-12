using System;
using AcklenAvenue.Data;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Helpers;
using SistemaZoologico.Dominio.Entidades;

namespace SistemaZoologico.Dominio.Datos
{
    public class MappingScheme : IDatabaseMappingScheme<MappingConfiguration>
    {
        private readonly string _configuration;

        #region IDatabaseMappingScheme<MappingConfiguration> Members

        public MappingScheme(string configuration)
        {
            _configuration = configuration;
        }


        public MappingScheme()
        {
            _configuration = "";
        }

        public Action<MappingConfiguration> Mappings
        {
            get
            {
                AutoPersistenceModel autoPersistenceModel = AutoMap.Assemblies(typeof (IEntidad).Assembly)
                    .Where(t => typeof (IEntidad).IsAssignableFrom(t))
                    
                    //.IncludeBase<LessonActionBase>()
                    .Conventions.Add(DefaultCascade.All())
                    .Conventions.Add<PrimarkeyConvention>();

                return x =>
                {
                    x.AutoMappings.Add(autoPersistenceModel);
                    if (_configuration.IsEmpty())
                    {
                    }
                };
            }
        }

        #endregion
    }
}