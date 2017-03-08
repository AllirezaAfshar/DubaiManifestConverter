using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using Ionic.Zip;
using Verifier.Exceptions;
using Verifier.Reources;

namespace Verifier.Utility
{
    public class Signer
    {
        public static byte[] Sign(byte[] data)
        {
            try
            {

                CspParameters cspParameters = new CspParameters();
                cspParameters.Flags |= CspProviderFlags.UseMachineKeyStore;   // all users of this computer have access
                cspParameters.Flags |= CspProviderFlags.UseExistingKey;
                cspParameters.KeyContainerName = ((App) Application.Current).ContainerName;
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048, cspParameters))
                {
                    try
                    {
//                        rsa.ExportCspBlob(true);
//                        String privatePath = PathHelper.GetPath("Resources\\privateKey.xml");
//                        if (File.Exists(privatePath))
//                        {
//                            File.Delete(privatePath);
//                        }
//                        File.WriteAllText(privatePath, rsa.ToXmlString(true));
//                        rsa.FromXmlString(File.ReadAllText(PathHelper.GetPath("Resources\\privateKey.xml")));
                        SHA1Managed sha1 = new SHA1Managed();
                        byte[] hash = sha1.ComputeHash(data);
                        return rsa.SignHash(hash, CryptoConfig.MapNameToOID("SHA1"));
                    }
                    finally
                    {
                        rsa.PersistKeyInCsp = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new UserInterfaceException("هنگام رمزنگاری اطلاعات خطا رخ داده است.");
            }
        }

        /// <summary>
        /// فایل را رمزنگاری کرده نتیجه ی آن را باز می گرداند
        /// </summary>
        /// <param name="originalPath">فایل اولیه</param>
        /// <param name="signedPath">فایل نهایی (رمز نگاری شده فایل اولیه)۱</param>
        public static void SignFile(string originalPath, string signedPath)
        {
            try
            {
                byte[] data = File.ReadAllBytes(originalPath);
                byte[] signed = Utility.Signer.Sign(data);

                

                using (ZipFile zip = new ZipFile())
                {
                    zip.AddEntry("original_file", data);
                    zip.AddEntry("signed_file", signed);
                    zip.Save(signedPath);
                }
            }
            catch (FormatException ex)
            {
                //Log.Error("Format Exception Error While Uploading File(BtnUploadFile_OnClick) in Hoopad Mode.", ex);
                UserInterfaceException exception = new UserInterfaceException(30002, ExceptionMessage.Format, ex);
                throw exception;
            }
            catch (Exception ex)
            {
                //Log.Error("Unspecific Exception Error While Uploading File(BtnUploadFile_OnClick) in Hoopad Mode.", ex);
                UserInterfaceException exception = new UserInterfaceException(30001, ExceptionMessage.FileOpenError, ex);
                throw exception;
            }
        }
    }
}
