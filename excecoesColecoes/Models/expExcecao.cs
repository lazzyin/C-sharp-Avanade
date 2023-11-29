using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace excecoesColecoes.Models
{
    public class expExcecao
    {
        public void Met1(){
            try{
                Met2();
                }catch(Exception){
                    System.Console.WriteLine("Exceção tratada");
                }
        }

        public void Met2(){
            Met3();
        }
        
        public void Met3(){
            Met4();
        }
        
        public void Met4(){
            trow new Exception("Ocorreu uma exceção");
        }
    }
}