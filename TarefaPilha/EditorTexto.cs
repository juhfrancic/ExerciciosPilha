using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaPilha
{
    public class EditorTexto
    {
        private Pilha historico = new Pilha();
        public void Digitar(string texto)
        {
            historico.Empilhar(texto);
            Console.WriteLine("Texto salvo!");
        }

        public void Desfazer()
        {
            string removido = historico.Desempilhar();
            if(removido != null)
            {
                Console.WriteLine($"Utimo item removido {removido}");
            }
        }

        public void ExibirHistorico()
        {
            historico.ExibirPilha();
        }
    }
}
