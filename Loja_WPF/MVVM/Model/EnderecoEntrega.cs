using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_WPF.MVVM.Model
{
    public class EnderecoEntrega
    {
        public string id { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string cep { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string complemento { get; set; }
        public string referencia { get; set; }
    }
}
