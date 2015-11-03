using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGrupoDeAlunos.Classes
{
    /// <summary>
    ///     Classe genérica que contém os métodos para montar os grupos dos alunos.
    /// </summary>
    /// <typeparam name="T"> Parâmetro que recebe a classe Aluno somente </typeparam>
    public class RepositorioAluno<T> where T : Aluno
    {
        List<T> alunos = new List<T>();

        /// <summary>
        ///     Método que adiciona os alunos em uma lista.
        /// </summary>
        /// <param name="aluno"> Objeto da classe Aluno </param>
        /// <returns> Lista de alunos </returns>
        public List<T> AdicionarAlunos(T aluno)
        {
            alunos.Add(aluno);

            return alunos;
        }

        /// <summary>
        ///     Método que monta uma lista de alunos randomizados a partir da lista padrão "alunos". 
        /// </summary>
        /// <param name="lista"> Lista de alunos na ordem que o usuário informou </param>
        /// <returns> Lista de alunos randomizados </returns>
        public List<T> Randomizar(List<T> lista)
        {
            var AlunosRandomizados = new List<T>();
            var indice = 0;
            var existe = false;

            var rand = new Random();

            foreach (var aluno in lista)
            {
                do // Laço de repetição para não deixar o sistema sortear alunos repetidos
                {
                    indice = rand.Next(0, lista.Count);

                    existe = AlunosRandomizados.Contains(aluno);
                }
                while (existe);

                AlunosRandomizados.Add(aluno);
            }

            return AlunosRandomizados;
        }

        /// <summary>
        ///     Método para separar os alunos randomizados em grupos, na quantidade de grupos que o usuário informar.
        /// </summary>
        /// <param name="AlunosRandomizados"> Lista de alunos randomizados </param>
        /// <param name="quantidadeGrupos"> quantidade de grupos informados pelo usuário </param>
        /// <returns> Uma lista de listas, ou seja, uma lista com diversos ou apenas um grupo </returns>
        public List<List<T>> Grupos(List<T> AlunosRandomizados, int quantidadeGrupos)
        {
            var i = 0;
            var grupos = new List<List<T>>();

            for (int j = 0; j < quantidadeGrupos; j++) // Adiciona a quantidade de grupos que o usuário informou la lista "grupos"
                grupos.Add(new List<T>());

            foreach (var aluno in AlunosRandomizados)
            {
                grupos[i].Add(aluno);

                // Ternário que controla a distribuição dos alunos nos grupos.
                i = (i == quantidadeGrupos - 1) ? 0 : i + 1;
            }
            
            return grupos;
        }
    }
}
