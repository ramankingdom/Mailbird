using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using Mailbird.Common.Interfaces;
using Mailbird.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MailbirdTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            SimpleIoc.Default.Register<IMailDownloader, MailDownloader>();
        }
    }
}
