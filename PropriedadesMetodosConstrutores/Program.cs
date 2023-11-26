using PropriedadesMetodosConstrutores.Models;
{
    
    
    

    Pessoa p1 = new Pessoa(name:"John",lastname:"Doe");//Usando construtor é possivel atribuir valor as variaveis na declaração de uso da classe
 //   p1.Name="John";
 //   p1.Lastname="Doe";
    p1.Age=25;
    
    p1.Apresentar(); 

    Pessoa p2 = new Pessoa(name:"Jane", lastname:"Doe");//Colocando o nome das variaveis para melhor entendimento do valor dos parametros
 //   p2.Name="Jane";
 //   p2.Lastname="Doe";
    p2.Age=18;

    
    p2.Apresentar();

    Curso cursoAdmin=new Curso();
    cursoAdmin.Name="Administração";
    cursoAdmin.Alunos=new List<Pessoa>();

    cursoAdmin.AddAlunos(p1);
    cursoAdmin.AddAlunos(p2);
    cursoAdmin.ListarAlunos();
}