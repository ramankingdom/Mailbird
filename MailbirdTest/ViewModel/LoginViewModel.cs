using MailBird.Common.BaseClasses;
using MailbirdTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using GalaSoft.MvvmLight.Command;

namespace MailbirdTest.ViewModel
{
    public class LoginViewModel : BaseNotificationClass, IHasPassword
    {
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged(this, nameof(UserName));
            }

        }

        private SecureString _password;
        public SecureString Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
                OnPropertyChanged(this, nameof(UserName));
            }
        }

         public RelayCommand<IHasPassword> LoginCommand { get; set; }
        

        private void InitializeCommands()
        {
            LoginCommand = new RelayCommand<IHasPassword>(ExecuteLoginCommand, CanExecuteLoginCommand);
        }

        private bool CanExecuteLoginCommand(IHasPassword obj)
        {
            return !string.IsNullOrEmpty(_userName) && Password != null;
        }
        private void ExecuteLoginCommand(IHasPassword obj)
        {
            
        }
    }
}
