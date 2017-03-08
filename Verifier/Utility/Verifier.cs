using System;
using System.IO;
using System.Security.Cryptography;
using Verifier.Exceptions;
using Verifier.Reources;

namespace Verifier.Utility
{
    public static class Verifier
    {
        /// <summary>
        /// چک می کند که آیا این سند معتبر می باشد یا خیر
        /// </summary>
        /// <param name="data"></param>
        /// <param name="signature"></param>
        /// <returns></returns>
        public static bool VerifyWithPem(byte[] data, byte[] signature)
        {
            string basePath =
                System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) + "\\";

            byte[] publicKey = File.ReadAllBytes(basePath + "Resources\\publicKey.der");

            RSACryptoServiceProvider csp = RSACryptoServiceHelper.DecodeX509PublicKey(publicKey);

            // Hash the data
            SHA1Managed sha1 = new SHA1Managed();
            byte[] hash = sha1.ComputeHash(data);

            // Verify the signature with the hash
            bool res = csp.VerifyData(hash, CryptoConfig.MapNameToOID("SHA1"), signature);

            return res;
        }

        public static bool VerifyWithNet(byte[] data, byte[] signature)
        {
            using (RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2048))
            {
                try
                {
                    csp.FromXmlString(new FileMapper().GetPublicKeyContent());

                    // Hash the data
                    SHA1Managed sha1 = new SHA1Managed();
                    byte[] hash = sha1.ComputeHash(data);

                    // Verify the signature with the hash
                    bool res = csp.VerifyHash(hash, CryptoConfig.MapNameToOID("SHA1"), signature);

                    return res;
                }
                finally
                {
                    csp.PersistKeyInCsp = true;
                }
            }


        }
    }
}
