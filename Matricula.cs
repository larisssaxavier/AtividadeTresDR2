using System;

public class Matricula
{
    // Atributos/Propriedades
    public string NomeDoAluno { get; set; }
    public string Curso { get; set; }
    public int NumeroMatricula { get; set; }
    public string Situacao { get; set; }
    public string DataInicial { get; set; }

    // Construtor
    public Matricula(string nomeDoAluno, string curso, int numeroMatricula, string situacao, string dataInicial)
    {
        NomeDoAluno = nomeDoAluno;
        Curso = curso;
        NumeroMatricula = numeroMatricula;
        Situacao = situacao;
        DataInicial = dataInicial;
    }
    // Método para trancar a matrícula
    public void Trancar()
    {
        Situacao = "Trancada";
        Console.WriteLine("Matrícula trancada com sucesso.");
    }

    // Método para reativar a matrícula
    public void Reativar()
    {
        Situacao = "Ativa";
        Console.WriteLine("Matrícula reativada com sucesso.");
    }

    // Método para exibir as informações da matrícula
    public void ExibirDados()
    {
        Console.WriteLine("\n----- Dados da Matrícula -----");
        Console.WriteLine($"Nome do Aluno: {NomeDoAluno}");
        Console.WriteLine($"Curso: {Curso}");
        Console.WriteLine($"Número da Matrícula: {NumeroMatricula}");
        Console.WriteLine($"Situação: {Situacao}");
        Console.WriteLine($"Data Inicial: {DataInicial}");
    }
    public static void Executar()
    {
        Matricula matricula1 = new Matricula("Larissa Xavier", "Engenharia da computação", 123456, "Ativa", "01/08/2024");

        matricula1.ExibirDados();

        Console.WriteLine("\n->TESTE");

        // Exibindo situação inicial
        Console.WriteLine("Situação inicial da matrícula:");
        matricula1.ExibirDados();

        // Trancando a matrícula
        matricula1.Trancar();
        Console.WriteLine("Após trancar a matrícula:");
        matricula1.ExibirDados();

        // Reativando a matrícula
        matricula1.Reativar();
        Console.WriteLine("Após reativar a matrícula:");
        matricula1.ExibirDados();
    }
}