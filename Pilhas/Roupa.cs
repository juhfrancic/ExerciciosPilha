using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilhas
{
    public class Roupa
    {
        public string Tipo { get; set; }
        public Roupa Proximo { get; set; }

        public Roupa(string tipo)
        {
            this.Tipo = tipo;
            this.Proximo = null;
        }
    }
}
