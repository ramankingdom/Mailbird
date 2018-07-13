
using System;

namespace Mailbird.Common.Interfaces
{
    public interface IMailDownloader
    {
        event EventHandler<IMailBirdEmail> EmailDownloaded;  
        void AddWork(IMailBirdEmail email);
    }
}