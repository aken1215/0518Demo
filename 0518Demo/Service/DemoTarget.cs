using _0518Demo.Service.ExtensionManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _0518Demo.Service
{
    public class DemoTarget
    {
        public bool IsValidLogFileName(string fileName)
        {
            FileExtensionMangager mgr = new FileExtensionMangager();

            return mgr.IsValid(fileName);
        }
    }


}