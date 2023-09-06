using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novaBiblioteca
{
    public interface IBibliotecaInterfaces
    {
        public interface ILivro
        {
            string Autor { get; set; }
            int NumeroPaginas { get; set; }
        }

        public interface IMidiaDigital
        {
            string Formato { get; set; }
            int NumeroMinutos { get; set; }
        }

        public interface IRevista
        {
            string Editora { get; set; }
            int NumeroEdicao { get; set; }
        }

    }
}
