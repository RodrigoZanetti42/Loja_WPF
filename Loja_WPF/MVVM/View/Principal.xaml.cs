using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Loja_WPF.MVVM.Model;
using Loja_WPF.MVVM.View;
using MaterialDesignColors;
using Newtonsoft.Json;

namespace Loja_WPF.MVVM.View
{
    /// <summary>
    /// Interação lógica para Principal.xam
    /// </summary>
    public partial class Principal : Page
    {
       

        public Principal()
        {
            InitializeComponent();

        }

        private async void BuscaPedido_Click(object sender, RoutedEventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://desafiotecnicosti3.azurewebsites.net/pedido");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode) 
                {
                    var a = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(a, Name="Funcionou");
                    
                    
                 }
                else
                {

                }
            }

        }

        private void Sair_Click(object sender, RoutedEventArgs e)
        {

        }

       
    }
}

