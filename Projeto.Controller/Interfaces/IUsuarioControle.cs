using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Controller.Interfaces
{
    interface IUsuarioControle : IControle
    {
        /// <summary>
        /// Retornar a EntidadeUsuario baseado no login informado.
        /// </summary>
        /// <param name="login">Login do usuário</param>
        /// <returns>EntidadeUsuario sem nenhuma associação.</returns>
        Model.Usuario RetornarPorLogin(string login);
    }
}
