using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Loja_WPF.MVVM.Model
{
    public class Root : RootBase
    {
        public string id { get; set; }
        public string status { get; set; }
        public double desconto { get; set; }
        public double frete { get; set; }
        public double subTotal { get; set; }
        public double valorTotal { get; set; }
        public List<Iten> itens { get; set; }
        public List<Pagamento> pagamento { get; set; }
    }

}

