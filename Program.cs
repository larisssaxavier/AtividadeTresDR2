// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        Console.WriteLine("Qual exercicio deseja executar?");
        Console.WriteLine("Exercicio 1 - Conceitos de classe, objeto, campo e método");
        Console.WriteLine("Exercicio 2 - Gerenciador de venda de ingrssos");

        var opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Livro.Executar();
                break;
            case "2":
                Ingressos.Teste();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}