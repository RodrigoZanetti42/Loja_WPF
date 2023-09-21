using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_WPF.MVVM.Model
{
    public class Cliente
    {
        public string id { get; set; }
        public string cnpj { get; set; }
        public string cpf { get; set; }
        public string nome { get; set; }
        public string razaoSocial { get; set; }
        public string email { get; set; }
        public DateTime dataNascimento { get; set; }
    }
}
