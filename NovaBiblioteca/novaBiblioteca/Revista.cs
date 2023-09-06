using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novaBiblioteca
{
    public class Revista : ItemBiblioteca
    {
        public int NumeroEdicao { get; set; }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Revista: {Titulo} (Edição {NumeroEdicao}, {AnoPublicacao})");
        }
    }
}
