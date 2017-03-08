using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Verifier.Utility
{
    public static class ParamUtility
    {
        public static Dictionary<String, String> GetParameters(String body)
        {
            String[] tokens = body.Split('&');
            Dictionary<String, String> res = new Dictionary<String, String>();
            foreach (String token in tokens)
            {
                String[] param = token.Split('=');
                res.Add(param[0], param[1]);
            }
            return res;
        }
    }
}
