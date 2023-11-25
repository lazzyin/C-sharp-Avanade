using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropriedadesMetodosConstrutores.Models
{
    public class Pessoa
    {

        private string _name;
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
            System.Console.WriteLine($"Nome:{Name} | Idade:{Age}");
            //Pega o valor fornecido pelo get e apresenta no console
        }
    }
}