using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Model
{
    public class ClasseBase
    {
        public virtual string sID { get; set; }

        #region Implementação para auditoria dos dados

        public virtual Usuario UsuarioAuditoria { get; set; }
        public virtual DateTime dtUltimaAtualizacao { get; set; }


        #endregion

        public ClasseBase()
        {
            sID = System.Guid.NewGuid().ToString();
            dtUltimaAtualizacao = System.DateTime.Now;
        }
    }
}
