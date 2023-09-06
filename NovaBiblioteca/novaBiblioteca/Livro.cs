using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static novaBiblioteca.IBibliotecaInterfaces;

namespace novaBiblioteca
{
    public class Livro : ItemBiblioteca, ILivro
    {
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }
        public bool EstaEmprestado { get; private set; }

        public string Emprestar()
        {
            if (!EstaEmprestado)
            {
                EstaEmprestado = true;
                return $"O livro '{Titulo}' foi emprestado com sucesso.";
            }
            else
            {
                return $"O livro '{Titulo}' já está emprestado.";
            }


        }


        public string Devolver()
        {
            if (EstaEmprestado)
            {
                EstaEmprestado = false;
                return $"O livro '{Titulo}' foi devolvido com sucesso.";
            }
            else
            {
                return $"O livro '{Titulo}' já foi devolvido anteriormente.";
            }
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Livro: {Titulo} ({AnoPublicacao}), Autor: {Autor}, Páginas: {NumeroPaginas}");
        }
    }
}

     


