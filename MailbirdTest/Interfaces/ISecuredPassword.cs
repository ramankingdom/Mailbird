using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MailbirdTest.Interfaces
{
    public interface IHasPassword
    {
        string UserName { get; set; }
        SecureString Password { get; set; }
    }
}
