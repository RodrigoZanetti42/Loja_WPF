using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_WPF.MVVM.Model
{
    public class Pagamento
    {
        public string id { get; set; }
        public int parcela { get; set; }
        public double valor { get; set; }
        public string codigo { get; set; }
        public string nome { get; set; }
    }
}
