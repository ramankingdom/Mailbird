using GalaSoft.MvvmLight.Command;
using MailBird.Common.BaseClasses;
using MailbirdTest.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailbirdTest.ViewModel
{
   public class MainViewModel: BaseNotificationClass
    {
        public MainViewModel()
        {
           
        }
        public ObservableCollection<MailBirdFolder> Folders { get; set; }
        private MailBirdFolder _selectedFolder;
        public MailBirdFolder SelectedFolder
        {
            get { return _selectedFolder; }
            set
            {
                _selectedFolder = value;
                OnPropertyChanged(this, nameof(SelectedFolder));
            }
        }
        public ObservableCollection<MailBirdEmail> Emails { get; set; }
        private MailBirdEmail _selectedEmail;
        public MailBirdEmail SelectedEmail
        {
            get { return _selectedEmail; }
            set {
                _selectedEmail = value;
                OnPropertyChanged(this, nameof(SelectedEmail));
                }
        }
        #region Commands
        
        #endregion


    }
}
