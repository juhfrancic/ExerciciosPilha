using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilhas
{
    public class PilhaDeRoupa
    {
        private Roupa head;
        
        PilhaDeRoupa()
        {
            this.head = null;
        }


        public bool Vazia()
        {
            if (head == null)
            {
                return true;
            }
            else
                return false;
            
        }

        public void Inserir(string tipo)
        {
            Roupa nova = new Roupa(tipo);

            nova.Proximo = head;
            head = nova;
        }

        public void Remover()
        {
            if (Vazia())
            {
                Console.WriteLine("Não tem o que remover");
            }
            else
            {
                Console.WriteLine($"Removendo {head.Tipo}");
                head = head.Proximo;
            }
        }

        public void Mostrar()
        {
            if (Vazia())
            {
                Console.WriteLine("Pilha vazia");
            }
            else 
            {
                Roupa atual = head;
                while(atual != null)
                {
                    Console.WriteLine(atual.Tipo);
                    atual = atual.Proximo;
                }
            }
        }
    }
}
