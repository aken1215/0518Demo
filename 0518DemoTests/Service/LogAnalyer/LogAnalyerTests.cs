using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0518Demo.Service.LogAnalyer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0518Demo.Service.ExtensionManager;
using _0518Demo.Service.Web;
using _0518Demo.Service.EMail;

namespace _0518Demo.Service.LogAnalyer.Tests
{
    [TestClass()]
    public class LogAnalyerTests
    {
        [TestMethod]
        public void Analyze_TooShortFileName_CallsWebService()
        {
            FakeWebService stubWebService = new FakeWebService();
            stubWebService.ToThrow = new Exception("fake exception");

            FakeEMailService mockEmail = new FakeEMailService();

            LogAnalyer log = new LogAnalyer(stubWebService, mockEmail);

            string tooShortFileName = "abc.txt";
            log.Analyze(tooShortFileName);

            StringAssert.Contains("someone@somewhere.com", mockEmail.To);
            StringAssert.Contains("cant log", mockEmail.Subject);
            StringAssert.Contains("fake exception", mockEmail.Body);
        }
    }

    public class FakeWebService : IWebService
    {
        public Exception ToThrow;
        public void LogError(string message)
        {
            if (ToThrow != null)
            {
                throw ToThrow;
            }
        }
    }

    public class FakeEMailService : IEMailService
    {
        public string To;
        public string Subject;
        public string Body;

        public void SendEMail(string to, string subject, string body)
        {
            To = to;
            Subject = subject;
            Body = body;
        }
    }

}