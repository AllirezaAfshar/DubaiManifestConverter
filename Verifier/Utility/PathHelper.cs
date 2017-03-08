using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Verifier.Utility
{
    public static class PathHelper
    {
        public static string GetPath(string url)
        {
            return Path.Combine(System.Windows.Forms.Application.StartupPath, url);
        }
    }
}
