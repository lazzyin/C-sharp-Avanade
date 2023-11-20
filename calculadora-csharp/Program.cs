using ExemploFundamentos.Models;

Calculadora calc = new Calculadora();

calc.Sum(10, 5);
calc.Sub(10, 8);
calc.Mult(10, 2);
calc.Div(500, 5);

calc.Pot(3,3);

calc.Seno(90);
calc.Cos(90);
calc.Tang(90);

int num=10;
int num1=num++;
int num2=num--;
System.Console.WriteLine($"Incrementando 10:");
System.Console.WriteLine($"{num++}");
System.Console.WriteLine($"Decrementando 10:");
System.Console.WriteLine($"{num--}");

calc.Raiz(81);