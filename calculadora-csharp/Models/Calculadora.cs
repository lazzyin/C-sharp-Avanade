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

        public void Pot(int x, int y){
            double result=Math.Pow(x,y);
            System.Console.WriteLine($"{x}^{y}={result}");
        }

        public void Seno(double ang){
            double radiano=ang * Math.PI/100;
            double seno=Math.Sin(radiano);
            System.Console.WriteLine($"Seno de {ang} = {Math.Round(seno,4)}");
        }
        public void Cos(double ang){
            double radiano=ang * Math.PI/100;
            double cos=Math.Cos(radiano);
            System.Console.WriteLine($"Coseno de {ang} = {Math.Round(cos,4)}");
        }
        public void Tang(double ang){
            double radiano=ang * Math.PI/100;
            double tan=Math.Tan(radiano);
            System.Console.WriteLine($"Tangente de {ang} = {Math.Round(tan,4)}");
        }
    }
}