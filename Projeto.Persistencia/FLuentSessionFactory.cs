using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Cfg.Db;
using System.Configuration;
using FluentNHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;


namespace Projeto.Persistencia
{
    public class FluentSessionFactory
    {
        public static ISessionFactory _sessionFactory;

        private static ISessionFactory CriarSessionFactory(bool criarBanco)
        {
            //Implementando um singleton para caso a sessão já exista
            if (_sessionFactory != null && !criarBanco)
                return _sessionFactory;

            #region Configuração de qual Banco de dados será utilizando

            //Arquivo de configuração de banco MySQL 
            IPersistenceConfigurer configDB = MySQLConfiguration.Standard.ConnectionString(
                    System.Configuration.ConfigurationManager.ConnectionStrings
                    ["ConVeiConnectionString"].ConnectionString);

            #endregion

            //Adicionando os arquivos de mapeamento
            var configFluent = Fluently.Configure().Database((IPersistenceConfigurer)configDB)
                .Mappings(m =>
                {
                    m.FluentMappings.AddFromAssemblyOf<Mapeamentos.UsuarioMap>();
                });

            //Gerando o Banco de dados
            if (criarBanco)
                configFluent = configFluent.ExposeConfiguration(GerarSchema);


            _sessionFactory = configFluent.BuildSessionFactory();

            return _sessionFactory;
        }

        public static ISession AbrirSession(bool criarBanco = false)
        {
            return CriarSessionFactory(criarBanco).OpenSession();
        }

        private static void GerarSchema(NHibernate.Cfg.Configuration config)
        {
            SchemaExport schema = new SchemaExport(config);

            //Deletando o Schema existente
            schema.Drop(false, true);

            //Gerar Schema
            schema.Create(false, true);
        }
    }
}