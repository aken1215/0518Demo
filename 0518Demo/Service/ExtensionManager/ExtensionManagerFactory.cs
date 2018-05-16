using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _0518Demo.Service.ExtensionManager
{
    public class ExtensionManagerFactory: IExtensionManagerFactory
    {
        public IExtensionManager Create()
        {
            return new FileExtensionMangager();
        }
    }
}