using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingLib
{
    [Serializable]
    public class ValidationResult
    {
        public ValidationResult(bool ok,String msg)
        {
            this.ok = ok;
            this.validationMessage = msg;
        }

        public bool ok;
        public String validationMessage;
    }
}
