using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_WPF.MVVM.Model
{
    public class Iten
    {
        public string id { get; set; }
        public string idProduto { get; set; }
        public string nome { get; set; }
        public int quantidade { get; set; }
        public double valorUnitario { get; set; }
    }
}
