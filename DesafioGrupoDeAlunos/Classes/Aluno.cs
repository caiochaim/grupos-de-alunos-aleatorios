using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGrupoDeAlunos.Classes
{
    public class Aluno : Pessoa
    {
        public override string NumeroDeAlunos()
        {
            return string.Format("\nInforme o número de alunos:");
        }

        public override string NomeDosAlunos(int i)
        {
            return string.Format("\nInforme o nome do {0}º aluno:", i);
        }

        public override string GrupoDeAlunos()
        {
            return string.Format("\nInforme o número de grupos:");
        }
    }
}
