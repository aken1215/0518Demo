using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _0518Demo.Service.ExtensionManager
{
    public class FileExtensionMangager: IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            if (fileName == "Success.txt")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}