using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using Verifier.Exceptions;
using Verifier.UI.Pages;

namespace Verifier.Utility
{
    public class RSACryptoKeyHelper
    {
        /// <summary>
        /// کلید عمومی و کلید خصوصی را ایجاد کرده و در فایل ذخیره می کند.
        /// </summary>
        public static void Generate()
        {
            string contaierName = ((App)Application.Current).ContainerName;

            #region DeleteExistedPrivateKey     // کلید قدیمی را حذف می کند

            {
                RSACryptoServiceProvider rsa = null;
                try
                {
                    CspParameters oldCspParameters = new CspParameters();
                    oldCspParameters.Flags |= CspProviderFlags.UseMachineKeyStore;
                    oldCspParameters.Flags |= CspProviderFlags.UseExistingKey;

                    oldCspParameters.KeyContainerName = contaierName;

                    using (rsa = new RSACryptoServiceProvider(2048, oldCspParameters))
                    {
                        rsa.PersistKeyInCsp = false;
                        // Archive obsolete private key!
                        String privatePath =
                            PathHelper.GetPath(String.Format("Resources\\arpk_{0}_{1}.xml", contaierName,
                                DateTime.Now.Ticks));
                        if (File.Exists(privatePath))
                        {
                            File.Delete(privatePath);
                        }
                        File.WriteAllText(privatePath, rsa.ToXmlString(true));
                    }
                }
                catch (CryptographicException ex)
                {
                    if (ex.Message.Contains("Key does not exist.") || ex.Message.Contains("Keyset does not exist"))
                    {
                        // DO Nothing    
                    }
                    else
                    {
                        throw;
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    throw new UserInterfaceException("هنگام حذف کلید خصوصی قدیمی خطای نامشخص رخ داده است.");
                }
            }

            #endregion DeleteExistedPrivateKey

            #region GenerateNewPrivateKey   // کلید خصوصی جدید ایجاد می کند  کلید عمومی را در فایل ذخیره می کند
            {
                CspParameters newCspParameters = new CspParameters();
                newCspParameters.Flags |= CspProviderFlags.UseMachineKeyStore;
                newCspParameters.Flags |= CspProviderFlags.UseUserProtectedKey;

                newCspParameters.KeyContainerName = contaierName;

                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048, newCspParameters))
                {
                    try
                    {
                        String publicPath = PathHelper.GetPath(String.Format("Resources\\puk_{0}_{1}.xml", contaierName, DateTime.Now.Ticks));
                        if (File.Exists(publicPath))
                        {
                            File.Delete(publicPath);
                        }
                        File.WriteAllText(publicPath, rsa.ToXmlString(false));

                    }
                    catch (Exception exception)
                    {
                    }
                    finally
                    {
                        rsa.PersistKeyInCsp = true;
                    }
                }
            }
            #endregion GeneratePrivateKey

            #region SavePublicKey   // کلید عمومی را در فایل ذخیره می کند
            SavePublicKeyContent(PathHelper.GetPath(String.Format("Resources\\puk_{0}_{1}.xml", contaierName, DateTime.Now.Ticks)));
            #endregion SavePublicKey

            #region CreateCheckAuthentication   // یک فایل به منظور چک ایجاد می کند که با کلید خصوصی تازه امضاء شده ایجاد گردیده است
            {
                Signer.SignFile(PathHelper.GetPath("Resources\\chk.txt"), PathHelper.GetPath(String.Format("Resources\\chk_{0}_{1}.zip", contaierName, DateTime.Now.Ticks)));
            }
            #endregion CreateCheckAuthentication
        }

        public static void SavePublicKeyContent(String publicPath)
        {
            string contaierName = ((App)Application.Current).ContainerName;

            CspParameters newCspParameters = new CspParameters();
            newCspParameters.Flags |= CspProviderFlags.UseMachineKeyStore;
            newCspParameters.Flags |= CspProviderFlags.UseExistingKey;

            newCspParameters.KeyContainerName = contaierName;

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048, newCspParameters))
            {
                try
                {
                    if (File.Exists(publicPath))
                    {
                        File.Delete(publicPath);
                    }
                    File.WriteAllText(publicPath, rsa.ToXmlString(false));

                }
                catch (Exception)
                {
                    // Do Nothing
                }
                finally
                {
                    rsa.PersistKeyInCsp = true;
                }
            }
        }

        private static String SecureStringToString(SecureString value)
        {
            IntPtr valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = Marshal.SecureStringToGlobalAllocUnicode(value);
                return Marshal.PtrToStringUni(valuePtr);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
            }
        }
    }
}
