using Loja_WPF.MVVM.Model;

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Loja_WPF.MVVM.ViewModel
{
    public class ClienteViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Cliente Cliente { get; set; }
             
        
        public ClienteViewModel() 
            
        {
            
        }

        public void NotfyPpropertyChange(string propertyName = null) 
        {
          PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));   
        }

    }
}
