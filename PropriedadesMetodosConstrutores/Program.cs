using PropriedadesMetodosConstrutores.Models;
{
    Pessoa p1 = new Pessoa();
    Pessoa p2 = new Pessoa();

    p1.Name="John Doe";
    p1.Age=25;
    
    

    p2.Name="Jane Doe";
    p2.Age=18;

    p1.Apresentar();
    p2.Apresentar();
}