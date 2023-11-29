using System.Globalization;//Permite mudar a localização do sistema, e retornar hora local ou valor monetario de acordo com o novo local

CultureInfo.DefaultThreadCurrentCulture=new CultureInfo("en-US");//Muda a localização do sistema para EUA

string num1="10";
string num2="5";
string result=num1+num2;//Ira retornar os valores concatenados (105) por serem considerados texto
System.Console.WriteLine(result);

int n1=10;
int n2=5;
int resultSoma=n1+n2;//Retorna a soma dos dois inteiros
System.Console.WriteLine(resultSoma);

string concatIntString=num1+n1;//Ira retornar o valor do texto concatenado com o do inteiro(105)
System.Console.WriteLine(concatIntString);


decimal valMonetario=50.00M;
System.Console.WriteLine($"{valMonetario:C}");
System.Console.WriteLine(valMonetario.ToString("C",CultureInfo.CreateSpecificCulture("en-US")));//Usando interpolação e o :C(currency) podemos formatar o decimal para retornar o valor como moeda, sera formatada de acordo com o local do sistema(R$,$).Tambem podemos mudar isto localmente
System.Console.WriteLine(valMonetario.ToString("C1"));
//Tambem podemos apresentar diferentes numeros de casa decimal usando C1,C2,etc...

double porcent=.50;
System.Console.WriteLine(porcent.ToString("P"));//Retorna uma porcentagem

DateTime data=DateTime.Now;//Retorna o valor atual do relogio do pc
System.Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));//Formata o DateTime para retornar como deseja
System.Console.WriteLine(data.ToShortDateString());//Retorna apenas a data
System.Console.WriteLine(data.ToShortTimeString());//retorna apenas a hora

DateTime dataParse= DateTime.Parse("06/06/2006 6:00");//Cria uma data especifica. caso tenha algum elemento impossivel de ser em uma data normal retorna erro
System.Console.WriteLine(dataParse);


string dataString="2018-10-31";
bool sucess = DateTime.TryParseExact(dataString, "yyyy-MM-dd",CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime datatp); 

if(sucess){
    System.Console.WriteLine($"Conversão realizada com sucesso. Data: {datatp}");
}else{
    System.Console.WriteLine($"{datatp} não é uma data valida");
}
