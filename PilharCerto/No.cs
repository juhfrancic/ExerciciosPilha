using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaCerto
{
    public class No
    {
        public string Item { get; set; }
        public No Proximo { get; set; }
        public No(string item)
        {
            this.Item = item;
            this.Proximo = null;
        }
    }
}
