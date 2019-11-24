using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Data
{
    public class ResponseData
    {
        public string ErrorKey { get; set; }
        public void SetError(string errKey) {
            this.ErrorKey = errKey;
        }
    }
}
