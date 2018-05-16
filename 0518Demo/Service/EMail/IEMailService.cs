using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0518Demo.Service.EMail
{
    interface IEMailService
    {
        void SendEMail(EmailInfo email);
    }
}
