using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Model
{
    public class Usuario : ClasseBase
    {
        public virtual string sLogin { get; set; }
        public virtual string sNome { get; set; }
        public virtual string sNomeTratamento { get; set; }
        public virtual string sSenha { get; set; }
        public virtual DateTime dtCadastro { get; set; }
        public virtual bool bAtivo { get; set; }
    }
}
