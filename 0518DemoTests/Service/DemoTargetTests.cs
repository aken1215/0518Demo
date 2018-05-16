using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0518Demo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0518Demo.Service.ExtensionManager;

namespace _0518Demo.Service.Tests
{
    [TestClass()]
    public class DemoTargetTests
    {
        [TestMethod()]
        public void IsValidLogFileNameTest()
        {
            Assert.Fail();
        }
    }


    public class AlwaysValidFakeExtensionManager : IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            return true;
        }
    }
}