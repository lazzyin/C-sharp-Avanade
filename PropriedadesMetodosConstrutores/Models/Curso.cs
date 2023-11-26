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
            foreach(Pessoa aluno in Alunos){
                System.Console.WriteLine(aluno.AllName);
            }
        }


    }
}