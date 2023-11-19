using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Calculadora
    {
        public void Sum(int x, int y){
            int result = x+y;
            System.Console.WriteLine($"{x}+{y}={result}");
        }

        public void Sub(int x, int y){
            int result = x-y;
            System.Console.WriteLine($"{x}-{y}={result}");
        }

        public void Mult(int x, int y){
            int result=x*y;
            System.Console.WriteLine($"{x}*{y}={result}");
        }
        
        public void Div(int x, int y){
            int result=x/y;
            System.Console.WriteLine($"{x}/{y}={result}");
        }
    }
}