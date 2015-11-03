using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGrupoDeAlunos.Classes
{
    public abstract class Pessoa
    {
        private string _nome;
        public string Nome
        {
            get { return this._nome; }

            set { this._nome = value; }
        }

        public virtual string NumeroDeAlunos()
        {
            return string.Empty;
        }

        public virtual string NomeDosAlunos(int i)
        {
            return string.Empty;
        }

        public virtual string GrupoDeAlunos()
        {
            return string.Empty;
        }
    }
}
