using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;

namespace Loja_WPF.MVVM.Model
{
    public class RootBase
    {
        public Cliente cliente { get; set; }
        public DateTime dataAlteracao { get; set; }
        public DateTime dataCriacao { get; set; }
        public EnderecoEntrega enderecoEntrega { get; set; }
        public int numero { get; set; }

        public async Task<List<Root>> ObterDados()
        {
            var client = new RestClient();
            var request = new RestRequest("https://desafiotecnicosti3.azurewebsites.net/pedido", Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK) 
               {
                   return JsonConvert.DeserializeObject<List<Root>>(response.Content);

                 
                   
            
               }
                
           
            else
                return null;




        }
    }
}