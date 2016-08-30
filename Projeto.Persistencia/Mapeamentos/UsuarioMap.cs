using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace Projeto.Persistencia.Mapeamentos
{
    public class UsuarioMap : ClassMap<Model.Usuario>
    {
        public UsuarioMap()
        {
            Id(u => u.sID).Length(40);
            Map(u => u.bAtivo).Not.Nullable();
            Map(u => u.dtCadastro).Not.Nullable();
            Map(u => u.dtUltimaAtualizacao).Not.Nullable();
            Map(u => u.sLogin).Not.Nullable().Length(30).Unique();
            Map(u => u.sNome).Not.Nullable().Length(50);
            Map(u => u.sNomeTratamento).Length(30);
            Map(u => u.sSenha).Not.Nullable().Length(30);
           Table("tbUsuario");
        }
    }
}

