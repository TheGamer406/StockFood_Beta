using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StockFood_Beta.ModelView
{
    public class InciodesesionViewModel : ViewModelBase
    {
        //campos 
        private string _username;
        private SecureString _password;
        private string _errormessage;
        private bool _IsViewVisible = true;

        //propiedades
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        public SecureString password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(password));
            }
        }
        public string errosmessage
        {
            get
            {
                return _errormessage;
            }
            set
            {
                _errormessage = value;
                OnPropertyChanged(nameof(errosmessage));
            }
        }
        //->Comandos 
        public ICommand InicioCommand { get; }
        public ICommand RecoverContraseñaCommand { get; }
        public ICommand ShowContraseñaCommand { get; }
        public ICommand RemenberContreseñaCommand { get; }

        //Constructor 
        public 

    }
}
