using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto.Controller.Concrete
{
    public class BancoConVei
    {
        public static bool gerarBanco()
        {
            try
            {
                Persistencia.FluentSessionFactory.AbrirSession(true);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

