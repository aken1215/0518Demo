using _0518Demo.Service.ExtensionManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _0518Demo.Service.LogAnalyer
{
    public class LogAnalyer
    {
        private IExtensionManager _manager;
        internal LogAnalyer(IExtensionManager manager)
        {
            _manager = manager;
        }

        public bool IsValidLogFileName(string fileName)
        {
            return _manager.IsValid(fileName);
        }
    }
}