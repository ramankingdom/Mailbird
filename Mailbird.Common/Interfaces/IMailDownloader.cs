using Mailbird.Common.ModelClasses;
using System;

namespace Mailbird.Common.Interfaces
{
    public interface IMailDownloader
    {
        event EventHandler<MailBirdEmail> EmailDownloaded;  
        void AddWork(MailBirdEmail email);
    }
}