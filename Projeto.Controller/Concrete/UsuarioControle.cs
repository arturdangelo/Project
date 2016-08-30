using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;
using NHibernate.LambdaExtensions;

namespace Projeto.Controller.Concrete
{
    public class UsuarioControle : Interfaces.IUsuarioControle
    {
        public Model.Usuario RetornarPorLogin(string login)
        {
            using (var session = Persistencia.FluentSessionFactory.AbrirSession(false))
            {
                var retorno = (from c in session.Linq<Model.Usuario>()
                               where c.sLogin == login
                               select c);
                return retorno.FirstOrDefault();
            }
        }

        public Model.ClasseBase inserir(Model.ClasseBase entidade)
        {
            using (var session = Persistencia.FluentSessionFactory.AbrirSession(false))
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(entidade);
                    transaction.Commit();
                    return entidade;
                }
            }
        }

        public void alterar(Model.ClasseBase entidade)
        {
            using (var session = Persistencia.FluentSessionFactory.AbrirSession(false))
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Update(entidade);
                    transaction.Commit();
                }
            }
        }

        public void excluir(Model.ClasseBase entidade)
        {
            using (var session = Persistencia.FluentSessionFactory.AbrirSession(false))
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(entidade);
                    transaction.Commit();
                }
            }
        }

        public Model.ClasseBase Retornar(string id)
        {
            using (var session = Persistencia.FluentSessionFactory.AbrirSession(false))
            {
                return session.Get<Model.Usuario>(id);
            }
        }

        public List<Model.ClasseBase> RetornarTodos()
        {
            using (var session = Persistencia.FluentSessionFactory.AbrirSession(false))
            {
                var retorno = (from c in session.Linq<Model.Usuario>()
                               select c);
                return retorno.ToList<Model.ClasseBase>();
            }
        }

        public List<Model.Usuario> RetornarTodosAtivos()
        {
            using (var session = Persistencia.FluentSessionFactory.AbrirSession(false))
            {
                var retorno = (from c in session.Linq<Model.Usuario>()
                               where c.bAtivo == true
                               select c);
                return retorno.ToList<Model.Usuario>();
            }
        }
    }
}
