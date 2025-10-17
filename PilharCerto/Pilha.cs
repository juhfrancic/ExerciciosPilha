using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaCerto
{
    public class Pilha
    {
        private No top;
        public bool EstaVazia()
        {
            if(top == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Empilhar(string item)
        {
            No nova = new No(item);
            nova.Proximo = top;
            top = nova;
        }

        public void Desempilhar()
        {
            if (EstaVazia())
            {
                Console.WriteLine("Impossível desempilhar, a pilha esta vazia");
            }
            else
            {
                Console.WriteLine($"Removendo {top.Item}");
                top = top.Proximo;
            }
        }

        public string Topo()
        {
            return $"Item topo: {top}";
        }

        public void ExibirPilha()
        {
            if (EstaVazia())
            {
                Console.WriteLine("A pilha está vazia!");
            }
            else
            {
                No atual = top;
                while (atual != null)
                {
                    Console.WriteLine(atual.Item);
                    atual = atual.Proximo;
                }
            }
        }
    }
}
