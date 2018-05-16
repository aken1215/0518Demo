using _0518Demo.Service.ExtensionManager;
using _0518Demo.Service.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _0518Demo.Service.LogAnalyer
{
    public class LogAnalyer
    {
        private IWebService _service;
        internal LogAnalyer(IWebService service)
        {
            _service = service;
        }

        public void Analyze(string fileName)
        {
            if (fileName.Length < 8)
            {
                _service.LogError("Filename too short:" + fileName);
            }
        }
    }
}