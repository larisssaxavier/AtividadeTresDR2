using System;

// DECLARAÇÃO DA CLASSE
class Livro
{
    //CAMPOS (ATRIBUTOS)
    public string? Titulo;  // Campo 1
    public int AnoPublicacao;  // Campo 2
    public bool Disponivel = true;  // Campo com valor padrão

    //MÉTODO
    public void Emprestar()
    {
        if (Disponivel)
        {
            Disponivel = false;
            Console.WriteLine($"Livro '{Titulo}' emprestado com sucesso!");
        }
        else
        {
            Console.WriteLine($"Livro '{Titulo}' já está emprestado.");
        }
    }

    public static void Executar()
    {
        //CRIAÇÃO DE UM OBJETO
        Livro meuLivro = new Livro();
        meuLivro.Titulo = "Dom Quixote";
        meuLivro.AnoPublicacao = 1605;

        //USO DO MÉTODO
        meuLivro.Emprestar();  // Empresta o livro
        meuLivro.Emprestar();  // Tenta emprestar novamente (já indisponível)
    }
}