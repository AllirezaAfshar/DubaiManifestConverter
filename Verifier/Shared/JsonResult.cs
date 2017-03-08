using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Verifier.Shared
{
    public class JsonResult
    {
        public bool isSuccess { get; set; }
        public object result { get; set; }
        public Object[] messages { get; set; }

        public override String ToString()
        {
            return String.Format("\nisSuccess: {0}\n result: {1}\n messages: {2}\n", isSuccess, result, messages);
        }
    }
}
