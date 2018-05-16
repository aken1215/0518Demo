using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _0518Demo.Service.EMail
{
    public class EmailInfo: IEquatable<EmailInfo>
    {
        public string Body;
        public string To;
        public string Subject;

        public override bool Equals(object obj)
        {
            var emailInfo = obj as EmailInfo;
            if (emailInfo != null)
            {
                return this.Equals(emailInfo);
            }

            return false;
        }

        public bool Equals(EmailInfo other)
        {
            return Body == other.Body && To == other.To && Subject == other.Subject;
        }
    }

}