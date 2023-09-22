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

        private async void BuscaPedido_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estamos preparando tudo..");

                 var Root = new Root();
                    var listarPedido = await Root.ObterDados();
           
            //Essa foreach deve levar os dados para o formulario em WPF
            foreach (var pedido in listarPedido)
            {

                int numero = pedido.numero;             // numero do pedido
                DateTime data = pedido.dataCriacao;     //data da criação do pedido
                string nome = pedido.cliente.nome;      //nome do cliente
                string status = pedido.status;          //status do pedido

            // passar esses dados para o formulario antes de fazer o download para o banco
            // criar rotina de code-first para movimentar demais rotinas


                
          

            }

        }

        private void Relatorio_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Sair_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
      }
    }


