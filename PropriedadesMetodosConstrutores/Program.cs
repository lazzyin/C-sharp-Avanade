using PropriedadesMetodosConstrutores.Models;
{
    Pessoa p1 = new Pessoa();
    Pessoa p2 = new Pessoa();
    Curso cursoAdmin=new Curso();

    p1.Name="John";
    p1.Lastname="Doe";
    p1.Age=25;    
    
    p2.Name="Jane";
    p2.Lastname="Doe";
    p2.Age=18;

    p1.Apresentar();
    p2.Apresentar();

    cursoAdmin.Name="Administração";
    cursoAdmin.Alunos=new List<Pessoa>();

    cursoAdmin.AddAlunos(p1);
    cursoAdmin.AddAlunos(p2);
    cursoAdmin.ListarAlunos();
}