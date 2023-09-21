using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_WPF.MVVM.Model
{
    public class Root
    {
        public string id { get; set; }
        public int numero { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime dataAlteracao { get; set; }
        public string status { get; set; }
        public double desconto { get; set; }
        public double frete { get; set; }
        public double subTotal { get; set; }
        public double valorTotal { get; set; }
        public Cliente cliente { get; set; }
        public EnderecoEntrega enderecoEntrega { get; set; }
        public List<Iten> itens { get; set; }
        public List<Pagamento> pagamento { get; set; }

       
    }
}
