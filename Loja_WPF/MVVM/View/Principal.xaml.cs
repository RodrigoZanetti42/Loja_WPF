using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
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
using Microsoft.Extensions.Options;
using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using RestSharp;

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

       

        private void Sair_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private async void BuscaPedido_Click(object sender,  Root item)
        {
            var Root = new Root();
            var listarCliente = await Root.ObterDados();
            foreach(var pedido  in listarCliente) 
            {
                
                int numero = pedido.numero;
                //string data = pedido.) ;
                string nome = pedido.cliente.nome;
                string status = pedido.status;

                
            }

          }

        private void Relatorio_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BuscaPedido_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Listamos todos os pedidos conforme solicitado.");

            
        }
    }
    }


