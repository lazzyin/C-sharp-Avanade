/*
using ExemploFundamentos.Models;

Pessoa pessoa1 = new Pessoa();
Pessoa pessoa2 = new Pessoa();

pessoa1.Name="V";
pessoa1.Age=20;
pessoa1.Height=1.75;
pessoa1.Mount=50000.0M;
pessoa1.Status=true;

pessoa2.Name="David";
pessoa2.Age=18;
pessoa2.Height=1.80;
pessoa2.Mount=200.0M;
pessoa2.Status=false;

pessoa1.Apresentar();
pessoa2.Apresentar();
*/

//===============================================
//===============================================
//===============================================


//TIPOS DE OPERADORES

//OPERADORES DE ATRIBUIÇÃO
/*
string hello="Hello, friend!"; //O operador de atribuição = serve para definir o valor de uma variavel
Console.WriteLine(hello);

int a=10;
int b=5;

int c=a+b;
 System.Console.WriteLine(c);

 a=5;
 System.Console.WriteLine(a);
//int a = 5 ; Não seria possivel fazer esta ação, por que a variavel ja foi declarada, caso queira mudar seu valor não pode passar o tipo dela novamente
c+=5;//Pega o valor que C ja possui e adiciona 5
System.Console.WriteLine(c);
c-=3;
System.Console.WriteLine(c);


//CONVERTENDO TIPOS DE VARIAVEIS

a=Convert.ToInt32("3");//Converte o "3" que seria uma string para int. Caso tente usar o Convert para converter um valor null ele retorna 0
System.Console.WriteLine(a);
a=int.Parse("5");//Converte o valor de string para inteiro. Caso use o Parse para converter um valor null ele retorna um erro.
System.Console.WriteLine(a);

int testeInt=5;
string testeString = testeInt.ToString();//converte o valor para string
System.Console.WriteLine(testeString);

//CAST IMPLICITO

double testeDoub = testeInt;//Como double aceita valores inteiros ele implicitamente modifica o valor da variavel. o mesmo não acontece com um inteiro recebendo um double
long testeLong=testeInt;
System.Console.WriteLine(testeDoub);
System.Console.WriteLine(testeLong);

double testeOrdem=4/2+1;//Primeiro sera feita a divisão do 4 por 2 e sera somado o valor a 1
System.Console.WriteLine(testeOrdem);
testeOrdem=4/(2+1);//A operação entre parenteses tem prioridade na execução da conta
System.Console.WriteLine(testeOrdem);
*/


//--------------------------------------------------


/*
//OPERADORES CONDICIONAIS

using System.Diagnostics;
using System.Linq.Expressions;

int qtdEstoque = 10;
int qtdCompra = 4;
bool vendaValida=qtdCompra>0 && qtdEstoque>=qtdCompra;
System.Console.WriteLine("Quantidade em estoque:"+qtdEstoque);
System.Console.WriteLine("Quantidade da compra:"+qtdCompra);
System.Console.WriteLine("é possivel efetuar a compra?:"+vendaValida);

if(qtdCompra==0){
    System.Console.WriteLine("Venda invalida");
}
else if(vendaValida){
    System.Console.WriteLine("Compra efetuada com sucesso");
}else{
    System.Console.WriteLine("Quantidade do item em falta no estoque");
};


//SWITCH CASE

System.Console.WriteLine("Digite uma letra:");
string letter = Console.ReadLine();



switch( letter){
     case "a" :
     case "e" :
     case "i" :
     case "o" :
     case "u" :
        System.Console.WriteLine("Vogal");
        break;

    default:
        System.Console.WriteLine("Consoante");
        break;
}
*/


//--------------------------------------------------



//OPERADORES LOGICOS

// Operador || Pipe, operador de OR

bool maiorIdade=false;//é maior de idae
bool perm = true;//Tem permissão de um adulto

if(maiorIdade || perm){//Se uma das condições for verdadeira faça:
    System.Console.WriteLine("Entrada permitida");
}else{
    System.Console.WriteLine("Entrada proibida");//Caso as duas condições forem falsas
}

//Operador &&, operador AND

bool presençaMin=false;//Presença minima
double media=6.5;//Nota media



if(presençaMin && media>=6){//Caso as duas condições sejam verdadeiras faça:
    System.Console.WriteLine("Aluno aprovado");
}else{
    System.Console.WriteLine("Aluno reprobado");//Caso uma das condições for falsa
}

//Operador !, operador de negação


bool chuva=true;
bool tarde=true;

if(!chuva && !tarde){//Caso as duas variaveis sejam falsas retorna:
    System.Console.WriteLine("Sair de bike");
}else{
    System.Console.WriteLine("Não sair");//Caso as duas variaveis sejam verdadeiras retorna.
}