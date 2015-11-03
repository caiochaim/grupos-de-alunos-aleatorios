using DesafioGrupoDeAlunos.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGrupoDeAlunos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var qtdeAlunos = 0;
            var i = 0;
            var numeroDeGrupos = 0;
            var lista = new List<Aluno>();
            var rep = new RepositorioAluno<Aluno>();
            var ListaRandomizada = new List<Aluno>();
            var grupos = new List<List<Aluno>>();

            do
            {
                Aluno aluno = new Aluno();

                if (i == 0)
                {
                    Console.WriteLine(aluno.NumeroDeAlunos());

                    qtdeAlunos = int.Parse(Console.ReadLine());
                    i++;
                } 
                else
                {
                    Console.WriteLine(aluno.NomeDosAlunos(i));
                    aluno.Nome = Console.ReadLine();

                    lista = rep.AdicionarAlunos(aluno);

                    i++;
                }
            }
            while (i <= qtdeAlunos);

            var msg = new Aluno();

            Console.WriteLine(msg.GrupoDeAlunos());
            numeroDeGrupos = int.Parse(Console.ReadLine());

            ListaRandomizada = rep.Randomizar(lista); // Passando a lista como argumento para ser randomizada.

            // Passando a lista randomizada e o numero de grupos como argumento para separar os alunos em grupos.
            grupos = rep.Grupos(ListaRandomizada, numeroDeGrupos);

            Console.WriteLine("\n");

            var j = 1;
            foreach (var grupo in grupos)
            {
                Console.WriteLine("Grupo {0}", j);

                foreach (var aluno in grupo)
                    Console.WriteLine(aluno.Nome);

                Console.WriteLine("");

                j++;
            }

            Console.ReadKey();
        }
    }
}
