using excecoesColecoes.Models;
using System.Collections.Generic;

/*
//TRY CATCH

try{//Vai executar o bloco de codigo e caso haja algum erro vai rodar o catch
    string[] frases= File.ReadAllLines("arquivo/teste.txt");

    foreach(string frase in frases){
        System.Console.WriteLine(frase);
    }
}
catch(FileNotFoundException ex){//Retorna uma exceção caso não encontre o arquivo chamado
    System.Console.WriteLine($"Ocorreu um erro: arquivo não encontrado. {ex.Message}");
}
catch(DirectoryNotFoundException ex){//Recebe uma exceção caso não encontre a pasta chamada
    System.Console.WriteLine($"Ocorreu um erro: caminho da pasta não encontrado. {ex.Message}");
}
catch(Exception ex){//Quando da um erro o catch lê a exception e retorna um bloco informando o erro
    System.Console.WriteLine($"Ocorreu uma exceção generica. {ex.Message}");//Bloco executado independente da exceção que acontecer
}
finally{//O bloco é executado independente de apresentar erro ou não
    System.Console.WriteLine("Finally");
}
*/
/*
//THROW

new expExcecao().Met1();


*/

//FILA
//Em uma fila o primeiro elemento adicionado sera tambem o primeiro a sair
/*
Queue<int> fila=new Queue<int>();//O primeiro elemento adicionado em uma fila sera tambem o primeiro a "sair" dela
fila.Enqueue(2);
fila.Enqueue(9);
fila.Enqueue(6);

foreach(int item in fila){
    System.Console.WriteLine(item);
}

System.Console.WriteLine($"Removendo elemento: {fila.Dequeue()} e adicionando o elemento 10");//Remove o primeiro elemento da fila
fila.Enqueue(10);//Adiciona o elemento ao final da fila
foreach(int item in fila){
    System.Console.WriteLine(item);
}
*/

//PILHA
//Em uma pilha o primeiro elemento adicionado sera o ultimo a sair, e o ultimo a ser adicionado sera o primeiro a sair.
/*
Stack<int> pilha=new Stack<int>();
pilha.Push(4);//Insere objeto no topo da pilha
pilha.Push(8);
pilha.Push(6);
pilha.Push(9);

foreach(int item in pilha){
    System.Console.WriteLine(item);//O primeiro elemento adicionado sera o ultimo a sair
}

System.Console.WriteLine($"Removendo o item do topo: {pilha.Pop()}");//remove o ultimo elemento da pilha

pilha.Push(7);
foreach(int item in pilha){
    System.Console.WriteLine(item);
}
*/

//DICTIONARY
//Dictionary é um modo de criar uma coleção de elementos unicos usando chave/valor
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("MG","Minas Gerais");
estados.Add("SP","São Paulo");
estados.Add("RJ","Rio de janeiro");

foreach(var item in estados){
    System.Console.WriteLine($"Chave:{item.Key} | Valor:{item.Value}");
}

estados.Remove("SP");//Remove o item usando a chave

estados["RJ"]="Rio de janeiro - valor alterado";//Altera o valor de um elemento. não é possivel alterar o valor da chave dos elementos.
foreach(var item in estados){
    System.Console.WriteLine($"Chave:{item.Key} | Valor:{item.Value}");
}

string chave="MG";
System.Console.WriteLine($"Verificando se existe a chave: {chave}");
if(estados.ContainsKey(chave)){
    System.Console.WriteLine($"Valor existente:{chave}");
    System.Console.WriteLine(estados[chave]);
}else{
    System.Console.WriteLine($"Chave inexistente");
}