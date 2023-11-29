namespace excecoesColecoes.Models
{
    


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

//THROW

new expExcecao().Met1();

}