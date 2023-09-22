using Loja_WPF.MVVM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_WPF.MVVM.ViewModel
{
    public class EnderecoEntregaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public EnderecoEntrega EnderecoEntrega { get; set; }


        public EnderecoEntregaViewModel()

        {

        }

        public void NotfyPpropertyChange(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
