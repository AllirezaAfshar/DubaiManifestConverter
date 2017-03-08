using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Verifier.Utility
{
    public class AccessControlHelper
    {
        /// <summary>
        /// چک می کند که آیا کاربر لاگین شده است یا خیر
        /// </summary>
        /// <returns></returns>
        public bool Verify()
        {
            try
            {
                byte[] data = new FileMapper().GetCheckFile();
                return Verifier.VerifyWithNet(data, Signer.Sign(data));
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
