using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StockFood_Beta.ModelView
{
    public class InciodesesionViewModel:ViewModelBase
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
        public bool IsViewVisible
        {
            get
            {
                return _IsViewVisible;
            }
            set
            {
                _IsViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }
        //-> Comandos
        public ICommand IncioSesionCommand { get; }
        public ICommand RecuperarContraseñaCommand { get; }
        public ICommand ShowContraseñaCommand { get; }
        public ICommand RemenberCommand { get; }

        //Constructor 
        public InciodesesionViewModel()
        {
            IncioSesionCommand = new ViewModelComand(ExecuteIncioSesionCommand, CanExecuteInicioSecionCommand);
            RecuperarContraseñaCommand = new ViewModelComand(p=>ExecuteRecuperarContraseñaCommand("",""));
        }

        private bool CanExecuteInicioSecionCommand(object obj)
        {
            bool ValidDate;
            if (string.IsNullOrWhiteSpace(Username) || Username.Length < 3 || password == null || password.Length < 3)
                ValidDate = false;
            else
                ValidDate = true;
            return ValidDate;
        }

        private void ExecuteIncioSesionCommand(object obj)
        {
            throw new NotImplementedException();
        }
        private void ExecuteRecuperarContraseñaCommand(string Username, string email)
        {
            throw new NotImplementedException();
        }
    }
}
