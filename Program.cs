// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        Console.WriteLine("Qual exercicio deseja executar?");
        Console.WriteLine("Exercicio 1 - Conceitos de classe, objeto, campo e método");
        Console.WriteLine("Exercicio 2 - Gerenciador de venda de ingrssos");
        Console.WriteLine("Exercicio 3 - Gestão de matrículas");
        Console.WriteLine("Exercicio 4 - Calculo de área e volume");

        var opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Livro.Executar();
                break;
            case "2":
                Ingressos.Teste();
                break;
            case "3":
                Matricula.Executar();
                break;
            case "4":
                FormasGeometricas.Executar();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}