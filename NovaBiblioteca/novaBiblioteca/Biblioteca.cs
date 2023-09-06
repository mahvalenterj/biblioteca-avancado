using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novaBiblioteca
{
    public class Biblioteca
    {
        private List<ItemBiblioteca> colecao;

        public Biblioteca()
        {
            colecao = new List<ItemBiblioteca>();
        }

        public void AdicionarItem(ItemBiblioteca item)
        {
            colecao.Add(item);
        }

        public void EmprestarItem(int numeroCatalogo)
        {
            ItemBiblioteca item = colecao.Find(i => i.NumeroCatalogo == numeroCatalogo);

            if (item != null)
            {
                if (item is IPodeSerEmprestado emprestavel)
                {
                    string resultadoEmprestimo = emprestavel.Emprestar();
                    Console.WriteLine(resultadoEmprestimo);
                }
                else
                {
                    Console.WriteLine($"O item '{item.Titulo}' não pode ser emprestado.");
                }
            }
            else
            {
                Console.WriteLine("Item não encontrado na biblioteca.");
            }
        }

        public void DevolverItem(int numeroCatalogo)
        {
            ItemBiblioteca item = colecao.Find(i => i.NumeroCatalogo == numeroCatalogo);

            if (item != null)
            {
                if (item is IPodeSerEmprestado emprestavel)
                {
                    string resultadoDevolucao = emprestavel.Devolver();
                    Console.WriteLine(resultadoDevolucao);
                }
                else
                {
                    Console.WriteLine($"O item '{item.Titulo}' não pode ser devolvido.");
                }
            }
            else
            {
                Console.WriteLine("Item não encontrado na biblioteca.");
            }
        }
    }
}
