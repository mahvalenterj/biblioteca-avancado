using novaBiblioteca;
using System.Runtime.Intrinsics.X86;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        {
            Biblioteca biblioteca = new Biblioteca();

            // Criar instâncias de diferentes tipos de itens da biblioteca
            Livro livro = new Livro
            {
                NumeroCatalogo = 1,
                Titulo = "Aventuras de Sherlock Holmes",
                Autor = "Arthur Conan Doyle",
                AnoPublicacao = 1892,
                NumeroPaginas = 320
            };

            MidiaDigital ebook = new MidiaDigital
            {
                NumeroCatalogo = 2,
                Titulo = "O Guia do Mochileiro das Galáxias",
                AnoPublicacao = 1979,
                Formato = "E-book"
            };

            Revista revista = new Revista
            {
                NumeroCatalogo = 3,
                Titulo = "National Geographic",
                NumeroEdicao = 100,
                AnoPublicacao = 2023
            };

            // Adicionar os itens à biblioteca
            biblioteca.AdicionarItem(livro);
            biblioteca.AdicionarItem(ebook);
            biblioteca.AdicionarItem(revista);

            // Demonstrar empréstimo e devolução
            biblioteca.EmprestarItem(1);  // Tentar emprestar o livro
            biblioteca.DevolverItem(1);   // Devolver o livro

            biblioteca.EmprestarItem(2);  // Tentar emprestar o e-book
            biblioteca.EmprestarItem(3);  // Tentar emprestar a revista
        }
    }
}