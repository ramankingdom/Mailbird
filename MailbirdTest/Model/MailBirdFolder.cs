using Mailbird.Common.Interfaces;
using MailBird.Common.BaseClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailbirdTest.Model
{
    public class MailBirdFolder : BaseNotificationClass, IMailBirdFolder
    {
        public readonly bool IsReadOnly;

        public ObservableCollection<IMailBirdFolder> SubFolders { get; set; }


        public MailBirdFolder(bool isReadOnly)
        {
            IsReadOnly = isReadOnly;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(this, nameof(Name));
            }
        }


        private int _unreadCount;

        public int UnreadCount
        {
            get { return _unreadCount; }
            set
            {
                _unreadCount = value;
                OnPropertyChanged(this, nameof(_unreadCount));
            }
        }

        private int _totalCount;
        public int TotalCount
        {
            get { return _totalCount; }
            set
            {
                _totalCount = value;
                OnPropertyChanged(this, nameof(TotalCount));
            }
        }

    }
}
