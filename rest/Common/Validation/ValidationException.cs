using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Validation
{
    public class ValidationException: System.Exception
    {
        public string ErrKey { get; set; }
        public ValidationException(string errKey)
        {
            this.ErrKey = errKey;
        }
    }

}
