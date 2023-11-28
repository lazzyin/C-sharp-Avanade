using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropriedadesMetodosConstrutores.Models
{
    public class Curso
    {
        public string Name{get;set;}
        public List<Pessoa> Alunos{get;set;}

        public void AddAlunos(Pessoa aluno){
            Alunos.Add(aluno);
        }

        public bool RemoveAluno(Pessoa aluno){
            return Alunos.Remove(aluno);           
        }

        public int QtdAlunosMatriculados(){
            int qtd=Alunos.Count;
            return qtd;
        }

        public void ListarAlunos(){
            System.Console.WriteLine($"Alunos do curso de {Name}:\n");
            
            for (int i = 0; i < Alunos.Count; i++)
            {
                //string texto="Nº "+ i + " "+ Alunos[i].FullName;//Utilizando + durante um texto concatenamos o texto com as variaveis
                string texto=$"Nº {i+1} - {Alunos[i].FullName}";//Utilizando um $ antes de começar a string podemos utilizar variaveis no texto dentro de {}. isto é conhecido como interpolação
                System.Console.WriteLine(texto);
            }

            
        }


    }
}