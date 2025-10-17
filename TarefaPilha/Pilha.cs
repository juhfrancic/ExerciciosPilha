using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TarefaPilha
{
    internal class Pilha
    {
        string[] itens = new string[10];
        public int top = -1;

        public bool EstaVazia()
        {
            return top == -1;
        }

        public bool EstaCheia()
        {
            return top == 9;
        }
        public void Empilhar(string item)
        {
            if (EstaCheia())
            {
                Console.WriteLine("Impossivel adicionar texto, a pilha ja esta cheia");
            }
            else
            {
                top++;
                itens[top] = item;
            }
        }

        public string Desempilhar()
        {
            if (EstaVazia())
            {
                Console.WriteLine("Não tem como retirar, a pilha esta vazia");
                return null;
            }
            else
            {
                string removido = itens[top];
                top--;
                return removido;
            }
        }

        public string topo()
        {
            return itens[top];
        }

        public void ExibirPilha()
        {
            if (EstaVazia())
            {
                Console.WriteLine("A pilha esta vazia");
            }
            else
            {
                Console.WriteLine("Itens da pilha: ");
                for(int i = top; i >= 0; i--)
                {
                    Console.WriteLine(itens[i]);
                }Console.WriteLine();
            }
        }
      
    }
}
