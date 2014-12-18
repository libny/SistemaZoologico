using AcklenAvenue.Data.NHibernate;

using DomainDrivenDatabaseDeployer;

using FluentNHibernate.Cfg.Db;

using NHibernate;

namespace SistemaZoologico.Dominio.Datos
{
    public class FabricaSession
    {
        static ISessionFactory _sessionFactory;

        public static ISession Crear()
        {
            if (_sessionFactory != null)
            {
                return _sessionFactory.OpenSession();
            }

            IPersistenceConfigurer databaseConfiguration = GetMySQLConfiguration();

            DatabaseDeployer dd = null;
            _sessionFactory =
                new SessionFactoryBuilder(new MappingScheme(), databaseConfiguration).Build(
                    cfg => { dd = new DatabaseDeployer(cfg); });
            dd.Update();

            return _sessionFactory.OpenSession();
        }

        static IPersistenceConfigurer GetMSSQLConfiguration()
        {
            MsSqlConfiguration databaseConfiguration =
                MsSqlConfiguration.MsSql2008.ShowSql()
                                  .ConnectionString(x => x.Is(ConnectionStrings.Get().ConnectionString));
            return databaseConfiguration;
        }
        static IPersistenceConfigurer GetMySQLConfiguration()
        {
            MySQLConfiguration databaseConfiguration =
                MySQLConfiguration.Standard.ShowSql()
                                  .ConnectionString(x => x.Is(ConnectionStrings.Get().ConnectionString));
            return databaseConfiguration;
        }
    }
}