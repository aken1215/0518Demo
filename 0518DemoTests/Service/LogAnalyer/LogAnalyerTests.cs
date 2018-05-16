using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0518Demo.Service.LogAnalyer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0518Demo.Service.ExtensionManager;

namespace _0518Demo.Service.LogAnalyer.Tests
{
    [TestClass()]
    public class LogAnalyerTests
    {
        [TestMethod()]
        public void IsValidFileName_NameSupportedExtension_ReturnsTrue()
        {
            IExtensionManagerFactory factory = new FakeExtensionManagerFactory();

            LogAnalyer log = new LogAnalyer(factory);

            bool result = log.IsValidLogFileName("short.txt");

            Assert.IsTrue(result);
        }
    }


    public class FakeExtensionManager : IExtensionManager
    {
        public bool WillBeValid = false;

        public bool IsValid(string fileName)
        {
            return WillBeValid;
        }
    }

    public class FakeExtensionManagerFactory : IExtensionManagerFactory
    {
        public bool WillBeValid = false;

        public IExtensionManager Create()
        {
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            myFakeManager.WillBeValid = true;

            return myFakeManager;
        }
    }
}