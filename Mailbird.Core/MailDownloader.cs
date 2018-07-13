using Mailbird.Common.Interfaces;
using MailBird.Core;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mailbird.Core
{
    public class MailDownloader : IMailDownloader
    {
        private ConcurrentQueue<IMailBirdEmail> _workItems;

        public  event EventHandler<IMailBirdEmail> EmailDownloaded;

        public MailDownloader()
        {
            _workItems = new ConcurrentQueue<IMailBirdEmail>();
        }

        public void AddWork(IMailBirdEmail email)
        {
            _workItems.Enqueue(email);
        }

        private void DownloadEmail(IMailBirdEmail email)
        {
            CustomClient client;
            if (MailConnectionManager.TryGetClient(out client))
            {

                if (this.EmailDownloaded != null)
                {
                    EmailDownloaded(this, email);
                }
            }
        }

        private void Process()
        {
            IMailBirdEmail email;
            _workItems.TryDequeue(out email);
            if (email != null && !email.isBodyDownloaded)
            {
                DownloadEmail(email);
            }
        }

    }
}
