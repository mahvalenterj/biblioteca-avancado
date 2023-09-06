using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novaBiblioteca
{ 
    public abstract class ItemBiblioteca
    {
        
        public int NumeroCatalogo { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public int NumeroPaginas { get; set; }

        public abstract void ExibirDetalhes();
        }
}

