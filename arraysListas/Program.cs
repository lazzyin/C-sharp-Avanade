int[] arrayInt = new int[3];

arrayInt[0]=42;
arrayInt[1]=7;
arrayInt[2]=9;
//arrayInt[3]=10; Indice invalido pois excede o tamanho do array


//PERCORRENDO OS ELEMENTOS DE UM ARRAY
System.Console.WriteLine("Percorrendo array com for");
for(int i=0;i<arrayInt.Length;i++){//percorrendo array com for
    System.Console.WriteLine($"Posição:{i} | Elemento:{arrayInt[i]}");
}

int countForeach=0;
System.Console.WriteLine("Percorrendo array com foreach");
foreach (int val in arrayInt)//percorrendo array com foreach
{
    System.Console.WriteLine($"Posição:{countForeach} | Posição:{val}");
    countForeach++;
}

/*

//REDIMENSIONANDO ARRAY USANDO RESIZE

Array.Resize(ref arrayInt, arrayInt.Length * 2);//Cria um novo array usando o antigo como referencia e copia os elementos antigos para este novo array

System.Console.WriteLine("Percorrendo array com for depois do resize");
for(int i=0;i<arrayInt.Length;i++){//percorrendo array com for
    System.Console.WriteLine($"Posição:{i} | Elemento:{arrayInt[i]}");
}

countForeach=0;
System.Console.WriteLine("Percorrendo array com foreach depois do resize");
foreach (int val in arrayInt)//percorrendo array com foreach
{
    System.Console.WriteLine($"Posição:{countForeach} | Posição:{val}");
    countForeach++;
}
*/

/*
//COPIANDO OS ELEMENTOS DE UM ARRAY PARA OUTRO


int[] arrayIntDobrado = new int[arrayInt.Length * 2];//Cria um novo array com o dobro da capacidade do arrayInt
Array.Copy(arrayInt, arrayIntDobrado,arrayInt.Length);//Copia todos os elementos do arrayInt e passa para o novo array

System.Console.WriteLine("Copia do array:");
foreach (int val in arrayIntDobrado)//percorrendo array com foreach
{
    System.Console.WriteLine($"Posição:{countForeach} | Posição:{val}");//Por não terem sido declarados os elementos a mais do novo array terão o valor de 0
    countForeach++;
}
*/

/*
//LISTAS
*/

List<string> listaString = new List<string>();

listaString.Add("Luffy");
listaString.Add("Zoro");
listaString.Add("Nami");
/*
System.Console.WriteLine("Percorrendo lista com for:");
for(int i=0;i<listaString.Count;i++){
    System.Console.WriteLine($"Posição:{i} | Elemento:{listaString[i]}");
}
System.Console.WriteLine("Percorrendo lista com foreach:");
int contador=0;
foreach (string item in listaString)
{
    System.Console.WriteLine($"Posição:{contador} | Elemento:{item}");
    contador++;
}
*/

System.Console.WriteLine($"Item na lista: {listaString.Count} | Capacidade:{listaString.Capacity}");//Count representa o numero de elementos dentro do lista, enquanto Capacity representa o valor da capacidade da lista
listaString.Add("Sanji");
listaString.Add("Chopper");
listaString.Add("Robin");
System.Console.WriteLine($"Item na lista: {listaString.Count} | Capacidade:{listaString.Capacity}");//Caso o numero de elementos passe o valor da capacidade da lista ela aumenta o valor da capcidade automaticamente

listaString.Remove("Robin");

System.Console.WriteLine($"Item na lista: {listaString.Count} | Capacidade:{listaString.Capacity}");
