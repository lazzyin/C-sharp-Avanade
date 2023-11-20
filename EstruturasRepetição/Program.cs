int num=3;

System.Console.WriteLine($"Tabuada de {num} usando for");
for(int i=1;i<=10;i++){
    
    System.Console.WriteLine($"{num} * {i} = {num*i}");
}

System.Console.WriteLine($"Tabuada de {num} usando while");
int cont=1;
while(cont<=10){
    System.Console.WriteLine($"{num} * {cont} = {num*cont}");
    cont++;

    /*if(cont == 7){//Para o loop ignorando a condição
        break;
    }*/
}

int soma =0, num1 =0;
do
{
    System.Console.WriteLine("Digite um numero: (0 para parar)");
    num1=Convert.ToInt32(System.Console.ReadLine());
    soma+=num1;
} while (num1!=0);

System.Console.WriteLine($"Total da soma dos numeros: {soma}");

string opcao;

while(opcao!="4"){
    System.Console.WriteLine("Digite sua opção:");
    System.Console.WriteLine("1-Novo cliente");
    System.Console.WriteLine("2-Buscar cliente");
    System.Console.WriteLine("3-Apagar cliente");
    System.Console.WriteLine("4-sair");

    opcao=System.Console.ReadLine();

    switch(opcao){
        case "1":
            System.Console.WriteLine("Adicionar novo cliente");
            break;
        case "2":
            System.Console.WriteLine("Pesquisar por cliente");
            break;
        case "3":
            System.Console.WriteLine("Deletar dados de um cliente");
            break;
        case "4":
            System.Console.WriteLine("Sair");
            break;
        default:
            System.Console.WriteLine("Opção invalida");
            break;
        }
}