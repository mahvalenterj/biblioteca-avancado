using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static novaBiblioteca.IBibliotecaInterfaces;

namespace novaBiblioteca
{
    public class MidiaDigital : ItemBiblioteca, IPodeSerEmprestado
    {
        public string Formato { get; set; }

        public string Emprestar()
        {
            return $"A mídia digital '{Titulo}' foi emprestada com sucesso.";
        }

        public string Devolver()
        {
            return $"A mídia digital '{Titulo}' foi devolvida com sucesso.";
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Mídia Digital: {Titulo} ({AnoPublicacao}), Formato: {Formato}");
        }
    }
}