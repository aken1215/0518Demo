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
        public IExtensionManager ExtensionManager {
            get { return _manager; }
            set { _manager = value; }
        }

        public LogAnalyer()
        {
            _manager = new FileExtensionMangager();
        }

        public bool IsValidLogFileName(string fileName)
        {
            return _manager.IsValid(fileName);
        }
    }
}