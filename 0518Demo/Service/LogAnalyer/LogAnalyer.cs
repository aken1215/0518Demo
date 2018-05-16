using _0518Demo.Service.ExtensionManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _0518Demo.Service.LogAnalyer
{
    public class LogAnalyer
    {
        public bool IsValidLogFileName(string fileName)
        {
            return GetManager().IsValid(fileName);
        }

        public virtual IExtensionManager GetManager()
        {
            return new FileExtensionMangager();
        }
    }
}