using System.Collections.ObjectModel;

namespace Mailbird.Common.Interfaces
{
    public interface IMailBirdFolder
    {
        string Name { get; set; }
        ObservableCollection<IMailBirdFolder> SubFolders { get; set; }
        int TotalCount { get; set; }
        int UnreadCount { get; set; }
    }
}