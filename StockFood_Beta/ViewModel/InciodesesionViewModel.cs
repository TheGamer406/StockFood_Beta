using StockFood_Beta.View;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StockFood_Beta.ViewModel
{
    public class InciodesesionViewModel : ViewModelBase
    {
        //campos 
        private string _username;
        private SecureString _password;
        private string _ErrorMessage;
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
        public string ErrorMessage
        {
            get
            {
                return _ErrorMessage;
            }
            set
            {
                _ErrorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }
        //->Comandos 
        public ICommand InicioCommand { get; }
        public ICommand RecoverContraseñaCommand { get; }
        public ICommand ShowContraseñaCommand { get; }
        public ICommand RemenberContreseñaCommand { get; }

        //Constructor
        public InciodesesionViewModel()
        {
            InicioCommand = new ViewModelComand(ExecuteInicioCommand, CanExecuteInicioCommand);
            RecoverContraseñaCommand = new ViewModelComand(p => ExecuteRecoverPassCommand("", ""));
        }
        private bool CanExecuteInicioCommand(object obj)
        {
            bool ValiDate;
            if (string.IsNullOrWhiteSpace(Username) || Username.Length < 5 || password == null || password.Length < 5)
                ValiDate = false;
            else
                ValiDate = true;
            return ValiDate;
        }

        private void ExecuteInicioCommand(object obj)
        {
            throw new NotImplementedException();
        }
        private void ExecuteRecoverPassCommand(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}
