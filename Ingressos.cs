using System;

class Ingressos
{
    public string _nomeDoShow { get; set; }       // Nome do evento musical
    public double _preco { get; set; }            // Preço unitário do ingresso
    public int _quantidadeDisponivel { get; set; } // Quantidade em estoque

    public Ingressos(string nomeDoShow, double preco, int quantidadeDisponivel)
    {
        if (string.IsNullOrWhiteSpace(nomeDoShow))
            throw new ArgumentException("Nome do show é obrigatório");

        if (preco <= 0)
            throw new ArgumentException("Preço deve ser positivo");

        if (quantidadeDisponivel < 0)
            throw new ArgumentException("Quantidade não pode ser negativa");

        _nomeDoShow = nomeDoShow;
        _preco = preco;
        _quantidadeDisponivel = quantidadeDisponivel;
    }

    public string GetNomeDoShow() => _nomeDoShow;
    public double GetPreco() => _preco;
    public int GetQuantidadeDisponivel() => _quantidadeDisponivel;

    public void AlterarPreco(double novoPreco)
    {
        if (novoPreco <= 0)
        {
            Console.WriteLine("Erro: O preço deve ser maior que zero.");
            return;
        }
        _preco = novoPreco;
        Console.WriteLine($"Preço atualizado para R$ {novoPreco:F2}");
    }

    public void AlterarQuantidade(int novaQuantidade)
    {
        if (novaQuantidade < 0)
        {
            Console.WriteLine("Erro: A quantidade não pode ser negativa.");
            return;
        }
        _quantidadeDisponivel = novaQuantidade;
        Console.WriteLine($"Quantidade disponível atualizada para {novaQuantidade} ingressos");
    }

    public string ExibirInformacoes()
    {
        return $"Show: {_nomeDoShow}\n" +
               $"Preço: R$ {_preco:F2}\n" +
               $"Quantidade Disponível: {_quantidadeDisponivel} ingressos";
    }

    public void SetNomeDoShow(string novoNome)
    {
        _nomeDoShow = novoNome;
    }

    public void SetPreco(double novoPreco)
    {
        _preco = novoPreco;
    }

    public void SetQuantidadeDisponivel(int novaQtd)
    {
        _quantidadeDisponivel = novaQtd;
    }

    public static void Teste()
    {
        Console.WriteLine("\n-- TESTE DA CLASSE INGRESSO --");

        //Instanciação do ingresso com valores iniciais
        Ingressos showRock = new Ingressos(
            nomeDoShow: "Asking Alenxandria 2025",
            preco: 680.00,
            quantidadeDisponivel: 10000
        );

        //Exibição das informações iniciais
        Console.WriteLine("\n--- Informações Iniciais ---");
        Console.WriteLine(showRock.ExibirInformacoes());

        //Teste de atualização de preço
        Console.WriteLine("\n--- Atualizando Preço ---");
        showRock.AlterarPreco(800.00);
        showRock.AlterarPreco(-230.00);

        //Teste de atualização de quantidade
        Console.WriteLine("\n--- Atualizando Quantidade ---");
        showRock.AlterarQuantidade(7620);
        showRock.AlterarQuantidade(-4560);

        //Exibição das informações finais
        Console.WriteLine("\n--- Informações Atualizadas ---");
        Console.WriteLine(showRock.ExibirInformacoes());

        //TESTE DE GETTERS E SETTERS
        Console.WriteLine("\n--- SEGUNDO TESTE ---");

        Ingressos festival = new Ingressos("Psica", 345, 8500);
        Console.WriteLine(festival.ExibirInformacoes());

        //Teste dos métodos Set
        Console.WriteLine("\n--- Atualizando Valores ---");
        festival.SetNomeDoShow("Psica 2025");
        festival.SetPreco(450.00);
        festival.SetQuantidadeDisponivel(4500);

        //Teste dos métodos Get
        Console.WriteLine("\n--- Valores Atualizados via Getters ---");
        Console.WriteLine($"Nome: {festival.GetNomeDoShow()}");
        Console.WriteLine($"Preço: R$ {festival.GetPreco():F2}");
        Console.WriteLine($"Quantidade: {festival.GetQuantidadeDisponivel()}");

        Console.WriteLine("\n--- Informações Consolidadas ---");
        Console.WriteLine(festival.ExibirInformacoes());

        //TESTE DE CONSTRUTORR
        Console.WriteLine("=== CRIAÇÃO DE INGRESSO COM CONSTRUTOR ===");

        //Criação do objeto usando o construtor
        Ingressos novoFestival = new Ingressos(
            nomeDoShow: "Rock in Rio 2025",
            preco: 399.90,
            quantidadeDisponivel: 20000
        );

        //Exibição das informações
        Console.WriteLine("\n--- Ingresso Criado ---");
        Console.WriteLine(novoFestival.ExibirInformacoes());
    }
}