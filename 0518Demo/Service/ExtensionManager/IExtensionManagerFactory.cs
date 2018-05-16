using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _0518Demo.Service.ExtensionManager
{
    public interface IExtensionManagerFactory
    {
        IExtensionManager Create();
    }
}