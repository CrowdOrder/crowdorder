using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Infrastructure
{
    public class AuthMessageSenderOptions
    {
        public string EmailUser 
        {
            get { return "noreply@crowdorder.co.uk"; }
            set { } 
        }
        public string EmailUserPassword
        {
            get { return "!QAZXSW\"crowd"; }
        }
        public string EmailUserMike
        {
            get { return "mike.patrick@crowdorder.co.uk"; }
            set { }
        }
        public string APIKey
        {
            get { return "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"; }
            set { }
        }
    }
}
