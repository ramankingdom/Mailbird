using MailbirdTest.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MailbirdTest
{
    public class WindowsManager
    {
        private Lazy<LoginWindow> _loginWindowLazy;
        private Lazy<MainWindow> _mainWindowLazy;
        

        public WindowsManager()
        {
            RegisterInstances();
        }

        private void RegisterInstances()
        {
            
        }


        public LoginWindow GetLoginWindow()
        {
            
            if (!_loginWindowLazy.IsValueCreated)
            {
                _loginWindowLazy = new Lazy<LoginWindow>(LazyThreadSafetyMode.PublicationOnly);
            }
            return _loginWindowLazy.Value;
        }

        public MainWindow GetMainWindow()
        {
            if (!_mainWindowLazy.IsValueCreated)
            {
                _mainWindowLazy = new Lazy<MainWindow>(LazyThreadSafetyMode.PublicationOnly);
            }
            return _mainWindowLazy.Value;
        }
    }
}
