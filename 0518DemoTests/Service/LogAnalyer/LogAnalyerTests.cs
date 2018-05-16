using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0518Demo.Service.LogAnalyer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0518Demo.Service.ExtensionManager;
using _0518Demo.Service.Web;

namespace _0518Demo.Service.LogAnalyer.Tests
{
    [TestClass()]
    public class LogAnalyerTests
    {
        [TestMethod]
        public void Analyze_TooShortFileName_CallsWebService()
        {
            FakeWebService mockService = new FakeWebService();
            LogAnalyer log = new LogAnalyer(mockService);

            string tooShortFileName = "abc.txt";
            log.Analyze(tooShortFileName);

            StringAssert.Contains("Filename too short:abc.txt",mockService.LastError);
        }
    }

    public class FakeWebService : IWebService
    {
        public string LastError;
        public void LogError(string message)
        {
            LastError = message;
        }
    }

}