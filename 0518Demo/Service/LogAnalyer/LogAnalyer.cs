using _0518Demo.Service.EMail;
using _0518Demo.Service.ExtensionManager;
using _0518Demo.Service.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _0518Demo.Service.LogAnalyer
{
    public class LogAnalyer
    {
        private IWebService _webService;
        private IEMailService _emailService;

        internal LogAnalyer(IWebService webService, IEMailService emailService)
        {
            _webService = webService;
            _emailService = emailService;
        }

        public void Analyze(string fileName)
        {
            if (fileName.Length < 8)
            {
                try
                {
                    _webService.LogError("Filename too short:" + fileName);
                }
                catch (Exception e)
                {
                    _emailService.SendEMail(new EmailInfo() { To = "someone@somewhere.com", Subject = "cant log", Body = e.Message });
                }

            }
        }
    }
}