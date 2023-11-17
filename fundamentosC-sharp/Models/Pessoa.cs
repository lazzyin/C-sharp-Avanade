using System;
using System.Collections.Generic; 
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Pessoa
    {
        
        public string Name {get;set;}
        public int Age {get;set;}
        public double Height{get;set;}
        public decimal Mount{get;set;}
        public bool Status{get;set;}

        public void Apresentar(){
            System.Console.WriteLine ($"Nome: {Name}\n Idade: {Age}\n Altura:{Height}\n Saldo:{Mount}\n Ativo:{Status}\n Ultimo acesso:{DateTime.Now.AddYears(54)} \n Bem-vindo!");
        }
    }
}