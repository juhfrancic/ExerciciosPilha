using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaCerto
{
    public class EditorTexto
    {
        Pilha historico = new Pilha();

        public string Digitar(string texto)
        {
            historico.Empilhar(texto);
            return texto;
        }

        public void Desfazer()
        {
            historico.Desempilhar();
        }

        public void MostrarHistorico()
        {
            historico.ExibirPilha();
        }
    }
}
