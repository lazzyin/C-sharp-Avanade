using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropriedadesMetodosConstrutores.Models
{
    public class Pessoa
    {
        public Pessoa(){//Caso não se tenha os valores pedidos para criar o construtor é usado um construtor vazio

        }
        public Pessoa(string name, string lastname){//O construtor deve obrigatoriamente ter o mesmo nome que a classe. Construtores não tem tipo de retorno
            Name=name;//Atribui o valor recebido no construtor como o valor da variavel Name
            Lastname=lastname;
        }

        private string _name;//Como esta propriedade tem o acesso privado ela so pode ser modificada dentro desta classe.
        private int _age;

        public string Name {

            get => _name.ToUpper();//Retorna o nome e deixa todas as letras em caps lock. como o retorno tem apenas uma linha foi utilizado => para indicar o valor de get
            

            set{
                if (value==""){
                    throw new ArgumentException("O nome não pode estar vazio");//Cria uma excessão para validar que o valor do nome não seja vazio
                }
                _name=value;
            }
        }//Implicitamente o set atribui o valor indicado a variavel. exemplo: John Doe. enquanto o get pega esse valor e utiliza nos metodos.
        public string Lastname{get;set;}
        
        public string FullName => $"{Name} {Lastname}".ToUpper();

        public int Age { 

            get=>_age;
            
            set{
                if (value<0){
                    throw new ArgumentException("A idade não pode ser menor que 0");//Cria uma excessão para verificar se a idade é valida
                }
                _age=value;
            }
        }

        

        public void Apresentar(){
            System.Console.WriteLine($"Nome:{FullName} | Idade:{Age}");
            //Pega o valor fornecido pelo get e apresenta no console
        }
    }
}